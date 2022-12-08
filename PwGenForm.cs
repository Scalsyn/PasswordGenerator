using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Web;
using System.Xml.Linq;
using System.Configuration;
using System.Text.RegularExpressions;

namespace PasswordGenerator
{
    public partial class PwGenForm : Form
    {
        #region GLOBALS

        //Start and End position in ASCII codetable:
        const byte LETTER_BEGIN = 97;
        const byte LETTER_END = 123;
        const byte CAPITAL_BEGIN = 65;
        const byte CAPITAL_END = 91;
        const byte SYMBOLE_BEGIN = 35;
        const byte SYMBOLE_END = 39;
        const byte NUMBER_BEGIN = 48;
        const byte NUMBER_END = 58;
        //Password generation logic:
        float CAPITAL_CHANCE = 4.0f;
        float NUMBER_CHANCE = 4.0f;
        float SYMBOLE_CHANCE = 5.0f;
        //Password classification logic:
        float CAPITAL_MODIFIER = 1.4f;
        float SYMBOLE_MODIFIER = 1.3f;
        float NUMBER_MODIFIER = 1.2f;
        float SCORE_WEAK = 8.0f;
        float SCORE_SECURE = 16.0f;
        float SCORE_STRONG = 35.0f;

        const string VAULT_PATH = "VAULT.txt";

        Random rnd;
        List<Password> vaultList;
        char[] passwordArray;

        #endregion

        #region EVENTS

        public PwGenForm()
        {
            InitializeComponent();
            rnd = new Random();
            vaultList = new List<Password>();
            passwordArray = new char[txtbox_password.MaxLength];

            //Create VAULT text file if it doesn't exist.
            //If it does, open it and fill the vaultList table with all tha data.
            if (!File.Exists(VAULT_PATH))
                using (FileStream fs = File.Create(VAULT_PATH));
            else
                using (StreamReader sr = new StreamReader(VAULT_PATH, Encoding.UTF8))
                    while (!sr.EndOfStream)
                        vaultList.Add(new Password(sr.ReadLine()));
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            //Setup check box logic.
            bool isCapitalOn = chbox_captialLetter.Checked;
            bool isSymboleOn = chbox_symboles.Checked;
            bool isNumberOn = chbox_number.Checked;
            int length = (int)num_length.Value;
            int index = 0;

            //Enable Copy button only if the passwordArray textbox is filled.
            if (length > 0)
                btn_copy.Enabled = true;

            //Password creation. It picks random characters according to the check box logic.
            //Every 4th character is a capital, every 4th is a number and every 5th is a symbole.
            //The generated characters are added to the global char array in order.
            GenerateRandomArray(isCapitalOn, isSymboleOn, isNumberOn, length);

            //Call function to randomize (random sort) the array until the given length.
            ShuffleArray(length);

            //Password strength calculation. It creates a score value which is cassified.
            //It's based on length and modified by attributes from the checkboxes.
            CalculatePasswordStrength(length, isCapitalOn, isSymboleOn, isNumberOn);
            //Convert the char array into a string. The string will have the given length.
            txtbox_password.Text = ConverCharArrayToString();
            //Turn every element of the array into '\0' character for the next password generation.
            ClearPasswordArray();
            lbl_message.Text = "";
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtbox_password.Text);
        }

        private void btn_vaultAdd_Click(object sender, EventArgs e)
        {
            string name = txtbox_vault.Text;
            string passw = txtbox_password.Text;

            //I. condition: if passwordArray is not filled, abort and inform the user.
            if (passw.Length < 6)
            {
                lbl_message.Text = "First generate a password!";
                txtbox_vault.Text = "";
                btn_vaultAdd.Enabled = false;
                return;
            }

            //II. condition: if name is too short, abort and inform the user.
            if (name.Length < 4)
            {
                lbl_message.Text = "The name must be longer than 3 characters!";
                txtbox_vault.Text = "";
                btn_vaultAdd.Enabled = false;
                return;
            }

            //III. condition: if the name contains numbers or special characters, abort and inform user.
            if (IsNameProper(name) == false)
            {
                lbl_message.Text = "The name can only contain letters!";
                txtbox_vault.Text = "";
                btn_vaultAdd.Enabled = false;
                return;
            }
            
            //IV. condition: if name is already in the list, abort and inform user.
            if (IsNameInList(name))
            {
                lbl_message.Text = "This name already exists in the vault!";
                txtbox_vault.Text = "";
                btn_vaultAdd.Enabled = false;
                return;
            }

            //Add new data to the list.
            vaultList.Add(new Password($"{name}|{passw}"));

            //Add new data to the VAULT text file.
            using (StreamWriter sw = new StreamWriter(VAULT_PATH, true, Encoding.UTF8))
                sw.WriteLine($"{name}|{passw}");

            //Form clean up.
            lbl_message.Text = "Password is successfully saved!";
            txtbox_vault.Text = "";
            txtbox_password.Text = "";
            lbl_pwStrength.Text = "";
            btn_copy.Enabled = false;
            btn_vaultAdd.Enabled = false;
        }

        private void txtbox_vault_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_vault.Text.Length == 0)
                btn_vaultAdd.Enabled = false;
            else
                btn_vaultAdd.Enabled = true;
        }

        private void btn_vaultClear_Click(object sender, EventArgs e)
        {
            //Ask user for assurance before delete all passwords.
            //Use a massage window for assurance feedback.
            DialogResult dr = MessageBox.Show("Are you sure to delete all the saved passwords?",
                      "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If user pressed Yes, then clear all data from VAULT text file with 0 stream length.
            //Also clear data from the list.
            if (dr == DialogResult.Yes)
            {
                FileStream fs = File.Open(VAULT_PATH, FileMode.Open);
                fs.SetLength(0);
                fs.Close();
                vaultList.Clear();
                lbl_message.Text = "The vault has been successfully cleared!";
            }
        }

        #endregion

        #region FUNCTIONS

        void GenerateRandomArray(bool isCapitalOn, bool isSymboleOn, bool isNumberOn, int length)
        {
            //Create a helper index to know where we at in the array.
            int index = 0;

            //First fill the array with the capital letters if it's enabled.
            if (isCapitalOn == true)
            {
                for (int i = 0; i < (int)Math.Floor(length / CAPITAL_CHANCE); i++)
                {
                    passwordArray[index] = (char)rnd.Next(CAPITAL_BEGIN, CAPITAL_END);
                    index++;
                }
            }
            //Then continue with the symboles if it's enabled.
            if (isSymboleOn == true)
            {
                for (int i = 0; i < (int)Math.Floor(length / SYMBOLE_CHANCE); i++)
                {
                    passwordArray[index] = (char)rnd.Next(SYMBOLE_BEGIN, SYMBOLE_END);
                    index++;
                }
            }
            //Then continue with the numbers if it's enabled.
            if (isNumberOn == true)
            {
                for (int i = 0; i < (int)Math.Floor(length / NUMBER_CHANCE); i++)
                {
                    passwordArray[index] = (char)rnd.Next(NUMBER_BEGIN, NUMBER_END);
                    index++;
                }
            }
            //Finally, finish the rest with the lowercase letters unit we rach the given length.
            //The rest of the array will remain '\0' character.
            for (int i = index; i < length; i++)
                passwordArray[i] = (char)rnd.Next(LETTER_BEGIN, LETTER_END);
        }
        
        bool IsNameInList(string name)
        {
            foreach (Password pw in vaultList)
                if (pw.getName() == name)
                    return true;

            return false;
        }

        bool IsNameProper(string name)
        {
            Regex r = new Regex(name);
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }
        
        void CalculatePasswordStrength(int length, bool isCapitalOn, bool isSymboleOn, bool isNumberOn)
        {
            //The base vaule is the length.
            float passwordStrengthScore = (float)length;

            //Modifiers: Capital - 40%, Numbers - 30%, Symboles - 20% increase.
            if (isCapitalOn == true) passwordStrengthScore *= CAPITAL_MODIFIER;
            if (isNumberOn == true) passwordStrengthScore *= NUMBER_MODIFIER;
            if (isSymboleOn == true) passwordStrengthScore *= SYMBOLE_MODIFIER;

            //Classification by the strength score value.
            if (passwordStrengthScore < SCORE_WEAK)
            {
                lbl_pwStrength.Text = "The password is weak!";
                lbl_pwStrength.ForeColor = Color.Red;
            }
            else if (passwordStrengthScore >= SCORE_WEAK && passwordStrengthScore < SCORE_SECURE)
            {
                lbl_pwStrength.Text = "The password is not secure!";
                lbl_pwStrength.ForeColor = Color.Red;
            }
            else if (passwordStrengthScore >= SCORE_SECURE && passwordStrengthScore < SCORE_STRONG)
            {
                lbl_pwStrength.Text = "The password is secure!";
                lbl_pwStrength.ForeColor = Color.Green;
            }
            else
            {
                lbl_pwStrength.Text = "The password is strong!";
                lbl_pwStrength.ForeColor = Color.DarkGreen;
            }
        }

        void ClearPasswordArray()
        {
            for (int i = 0; i < passwordArray.Length; i++)
                passwordArray[i] = '\0';
        }
        
        string ConverCharArrayToString()
        {
            //We use string builder as the password length can be long.
            StringBuilder sb = new StringBuilder();

            //The end of the array is when we reach the '\0' character.
            //That's how we know how long the password is.
            //We don't want to append '\0' characters to out final string.
            for (int i = 0; i < passwordArray.Length; i++)
            {
                if (passwordArray[i] == '\0') break;
                sb.Append(passwordArray[i]);
            }
            return sb.ToString();
        }

        void ShuffleArray(int length)
        {
            //It's a typical random sort.
            //It's randomly moving elements within the given length (max index with is decreasing).
            //It counts from the given length until it reaches 1.
            while (length > 1)
            {
                int k = rnd.Next(length--);
                char tmp = passwordArray[length];
                passwordArray[length] = passwordArray[k];
                passwordArray[k] = tmp;
            }
        }

        #endregion

    }
}