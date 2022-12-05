using System.IO;
using System.Text;
using System.Web;
using System.Xml.Linq;


namespace PasswordGenerator
{
    public partial class PwGenForm : Form
    {
        #region GLOBALS

        const byte LETTER_BEGIN = 97;
        const byte LETTER_END = 123;
        const byte CAPITAL_BEGIN = 65;
        const byte CAPITAL_END = 91;
        const byte SYMBOLE_BEGIN = 35;
        const byte SYMBOLE_END = 39;
        const byte NUMBER_BEGIN = 48;
        const byte NUMBER_END = 58;

        Random rnd;
        StringBuilder sb;
        List<Password> vaultList;

        #endregion

        #region EVENTS

        public PwGenForm()
        {
            InitializeComponent();
            rnd = new Random();
            sb = new StringBuilder();
            vaultList = new List<Password>();

            if (!File.Exists("VAULT.txt"))
                using (FileStream fs = File.Create("VAULT.txt")) ;
            else
                using (StreamReader sr = new StreamReader("VAULT.txt", Encoding.UTF8))
                    while (!sr.EndOfStream)
                        vaultList.Add(new Password(sr.ReadLine()));
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            bool isCapitalOn = chbox_captialLetter.Checked;
            bool isSymboleOn = chbox_symboles.Checked;
            bool isNumberOn = chbox_number.Checked;
            int length = (int)num_length.Value;

            if (length > 0)
                btn_copy.Enabled = true;

            for (int i = 0; i < length; i++)
            {
                switch (rnd.Next(0, 10))
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4: sb.Append(GenerateRandomLetter(isCapitalOn)); break;
                    case 5:
                    case 6:
                    case 7: sb.Append(GenerateRandomNumber(isCapitalOn, isNumberOn)); break;
                    case 8:
                    case 9: sb.Append(GenerateRandomSymbole(isCapitalOn, isSymboleOn)); break;
                    default: sb.Append(GenerateRandomLetter(isCapitalOn)); break;
                }
            }

            txtbox_password.Text = sb.ToString();
            sb.Clear();
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

            if (passw.Length < 6)
            {
                lbl_message.Text = "First generate a password!";
                txtbox_vault.Text = "";
                btn_vaultAdd.Enabled = false;
                return;
            }

            if (name.Length < 4)
            {
                lbl_message.Text = "The name must be longer than 3 characters!";
                txtbox_vault.Text = "";
                btn_vaultAdd.Enabled = false;
                return;
            }

            if (IsNameInList(name))
            {
                lbl_message.Text = "This name already exists in the vault!";
                txtbox_vault.Text = "";
                btn_vaultAdd.Enabled = false;
                return;
            }

            vaultList.Add(new Password($"{name}|{passw}"));

            using (StreamWriter sw = new StreamWriter("VAULT.txt", true, Encoding.UTF8))
                sw.WriteLine($"{name}|{passw}");

            lbl_message.Text = "Password is successfully saved!";
            txtbox_vault.Text = "";
            txtbox_password.Text = "";
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
            DialogResult dr = MessageBox.Show("Are you sure to delete all the saved passwords?",
                      "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                FileStream fs = File.Open("VAULT.txt", FileMode.Open);
                fs.SetLength(0);
                fs.Close();
                lbl_message.Text = "The vault has been successfully cleared!";
            }
        }

        #endregion

        #region FUNCTIONS

        char GenerateRandomLetter(bool isCapitalOn)
        {
            if (isCapitalOn == true)
                if (rnd.Next(3) == 1)
                    return (char)rnd.Next(CAPITAL_BEGIN, CAPITAL_END);

            return (char)rnd.Next(LETTER_BEGIN, LETTER_END);
        }

        char GenerateRandomSymbole(bool isCapitalOn, bool isSymboleOn)
        {
            if (isSymboleOn == true)
                return (char)rnd.Next(SYMBOLE_BEGIN, SYMBOLE_END);

            return GenerateRandomLetter(isCapitalOn);
        }

        char GenerateRandomNumber(bool isCapitalOn, bool isNumberOn)
        {
            if (isNumberOn == true)
                return (char)rnd.Next(NUMBER_BEGIN, NUMBER_END);

            return GenerateRandomLetter(isCapitalOn);
        }

        bool IsNameInList(string name)
        {
            foreach (Password pw in vaultList)
                if (pw.getName() == name)
                    return true;

            return false;
        }

        #endregion

    }
}