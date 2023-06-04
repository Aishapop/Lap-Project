using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOB
{
    public partial class DepositPage : Form
    {
        private string Email;
        public DepositPage(string email)
        {
            InitializeComponent();
            Email = email;
        }

        private void SoortenRekeningDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateInputs()
        {
            string soortrekening = SoortenRekeningDropDown.Text;
            string bedragtext = BedragText.Text.Replace("€","");

            if(string.IsNullOrEmpty(soortrekening) || string.IsNullOrEmpty(bedragtext))
            {
                MessageBox.Show("Please fill in all the fields!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (var item in bedragtext)
            {
                if (!"1234567890.".Contains(item))
                {
                    MessageBox.Show("Voer enkel nummers in dit veld in", "bedrag error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BedragText.Clear();
                    return false;
                }
            }
            return true;
        }
        private void DepositPage_Load(object sender, EventArgs e)
        {
            SoortenRekeningDropDown.DataSource = Enum.GetValues(typeof(Types));
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                string soortrekening = SoortenRekeningDropDown.Text;
                string bedragtext = BedragText.Text.Replace("€","");
                float bedrag = (float)Convert.ToDouble(bedragtext);
                Data data = new Data();
                User user = data.SelectUSerIfExist(Email);

                // Parse the item name into the corresponding enumeration value
                object enumValue = Enum.Parse(Type.GetType("EOB.Types"), soortrekening);

                // Cast the enumValue to the desired enumeration type
                Types selectedRekening = (Types)enumValue;

                user.CreateAccount(selectedRekening);

                //zet het bedrag als balance voor de user
                List<Account> balances = user.AccountList;
                Account balance = balances[balances.Count - 1];
                balance.DepositMoney(bedrag);

                FormUtils.OpenForm(new ClientMainPage(Email));
                BedragText.Clear();
            }
        }

        private void BedragText_TextChanged(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(Email));
        }
    }
}
