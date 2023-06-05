using MySqlConnector;
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
    public partial class AutomatischeOverschrijvingPage : Form
    {
        private User User;
        internal AutomatischeOverschrijvingPage(User user)
        {
            InitializeComponent();
            this.User = user;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(User));
        }

        private void BeginDateAutoOverschrij_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void EndDateAutoOverschrij_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TermijnDropDownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BedragText_TextChanged(object sender, EventArgs e)
        {

        }

        private void OntvangersRekeningNR_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToevoegenAutoOverschrButton_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                string mijnrekeningnrtext = MijnRekeningenDropDown.Text.Replace("BE","").Trim();
                int mijnrekeningNr = Convert.ToInt32(mijnrekeningnrtext);
                string rekeningNrText = OntvangersRekeningNR.Text.Replace("BE", "").Trim();
                int rekeningNr = Convert.ToInt32(rekeningNrText);
                string bedragtext = BedragText.Text.Replace("€", "").Trim();
                decimal bedrag = Convert.ToDecimal(bedragtext);
                string termijn = TermijnDropDownMenu.Text;
                DateTime beginDate1 = BeginDateAutoOverschrij.Value.Date;
                DateTime endDate1 = BeginDateAutoOverschrij.Value.Date;
                string beginDate = beginDate1.ToString("yyyy-MM-dd HH:mm:ss");
                string endDate = endDate1.ToString("yyyy-MM-dd HH:mm:ss");

                //all de informatie gebruiken om een auto overschrijving te maken ***********
                List<Account> accounts = User.AccountList;
                Account rekening = accounts[0]; // give it a random account
                foreach(Account account in accounts)
                {
                    if(account.AccountNumber == mijnrekeningNr)
                    {
                        rekening = account; // give this variable the right account
                    }
                }
                rekening.SetAutomaticTransfer(beginDate, termijn, endDate, bedrag, rekeningNr);
                FormUtils.OpenForm(new ClientMainPage(User));
                OntvangersRekeningNR.Clear();
                BedragText.Clear();
            }
        }
        private bool ValidateInputs()
        {
            DateTime beginDate = BeginDateAutoOverschrij.Value.Date;
            DateTime endDate = BeginDateAutoOverschrij.Value.Date;

            string mijnrekeningen = MijnRekeningenDropDown.Text.Replace("BE","").Trim();
            string termijn = TermijnDropDownMenu.Text;
            string rekeningNrText = OntvangersRekeningNR.Text.Replace("BE", "").Trim();
            string bedragtext = BedragText.Text.Replace("€", "").Trim();
            if (string.IsNullOrEmpty(rekeningNrText) || string.IsNullOrEmpty(bedragtext) || string.IsNullOrEmpty(mijnrekeningen) || string.IsNullOrEmpty(termijn))
            {
                MessageBox.Show("Please fill in all the fields!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (var item in rekeningNrText)
            {
                if(!"1234567890".Contains(item))
                {
                    MessageBox.Show("Voer enkel nummers in dit veld in", "rekeningNr error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OntvangersRekeningNR.Clear();
                    return false;                 
                }
            }     

            foreach (var item in bedragtext)
            {
                if (!"1234567890.".Contains(item))
                {
                    MessageBox.Show("Voer enkel nummers of een punt in, in dit veld", "bedrag error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BedragText.Clear();
                    return false;
                }
            }

            if (beginDate > endDate)
            {
                MessageBox.Show("De datums kloppen niet", "Datum error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (termijn != "wekelijks" && termijn != "maandelijks" && termijn != "jaarlijks")
            {
                MessageBox.Show("Het ingevoerde termijn is geen optie", "Termijn error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void AutomatischeOverschrijving_Load(object sender, EventArgs e)
        {
            string connectionString =
            "datasource=127.0.0.1;" +
            "port=3306;" +
            "username=root;" +
            "password=root;" +
            "database=eob;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Create a command to retrieve the data
                MySqlCommand command = new MySqlCommand("SELECT * FROM rekening", connection);

                // Create a data adapter to fill the dataset
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    // Fill the dataset
                    adapter.Fill(dataTable);

                    // Iterate over the data and populate the ListView control
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (Convert.ToInt32(row["User_id"]) == User.ID)
                        {
                            string item = "BE" + row["Rekening_nr"];

                            MijnRekeningenDropDown.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Clean up resources
                    adapter.Dispose();
                    command.Dispose();
                    connection.Close();
                }
            }          
        }

        private void MijnRekeningenDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
