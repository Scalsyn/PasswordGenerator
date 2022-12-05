using System.Text;

namespace PasswordGenerator
{
    public partial class PwGenForm : Form
    {
        Random rnd = new Random();
        
        public PwGenForm()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            bool isCapitalOn = chbox_captialLetter.Checked;
            bool isSymboleOn = chbox_symboles.Checked;
            bool isNumberOn = chbox_number.Checked;
            int length = (int)num_length.Value;
            int chanceVariable = 0;

            StringBuilder sb = new StringBuilder();
            
            if (isCapitalOn == true) chanceVariable++;
            if (isSymboleOn == true) chanceVariable++;
            if (isNumberOn == true) chanceVariable++;

            for (int i = 0; i < length; i++)
            {
                
                switch (rnd.Next(0, chanceVariable))
                {
                    case 1: sb.Append((char)rnd.Next(97, 123)); break;

                    default: sb.Append((char)rnd.Next(97, 123)); break;
                }
            }

        }
    }
}