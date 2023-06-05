using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOB
{
    public partial class NormaleOverschrijvingPage : Form
    {
        private User User;
        internal NormaleOverschrijvingPage(User user)
        {
            InitializeComponent();
            this.User = user;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(User));
        }

        private void NormaleOverschrijvingPage_Load(object sender, EventArgs e)
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

                    // Get the users id

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
        private bool ValidateInputs()
        {
            string mijnrekeningnr = MijnRekeningenDropDown.Text.Replace("BE","").Trim();
            string ontvangerrekening = OntvangerRekeningNrText.Text.Replace("BE","").Trim();
            string bedragtext = BedragText.Text.Replace("€","").Trim();

            if(string.IsNullOrEmpty(mijnrekeningnr) || string.IsNullOrEmpty(ontvangerrekening) || string.IsNullOrEmpty(bedragtext))
            {
                MessageBox.Show("Please fill in all the fields!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (var item in ontvangerrekening)
            {
                if (!"1234567890".Contains(item))
                {
                    MessageBox.Show("Voer enkel nummers in dit veld in", "rekeningNr error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OntvangerRekeningNrText.Clear();
                    return false;
                }
            }
            foreach (var item in bedragtext)
            {
                if (!"1234567890.".Contains(item))
                {
                    MessageBox.Show("Voer enkel nummers of een komma in, in dit veld", "bedrag error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BedragText.Clear();
                    return false;
                }
            }

            return true;
        }

        private void OverschrijvenButton_Click(object sender, EventArgs e)
        {           
            if (ValidateInputs())
            {
                string mijnrekeningnrtext = MijnRekeningenDropDown.Text.Replace("BE","").Trim();
                int mijnrekeningnr = Convert.ToInt32(mijnrekeningnrtext);
                string ontvangerrekeningtext = OntvangerRekeningNrText.Text.Replace("BE", "").Trim();
                int ontvangerrekening = Convert.ToInt32(ontvangerrekeningtext);
                string bedragtext = BedragText.Text.Replace("€", "").Trim();
                decimal bedrag = decimal.Parse(bedragtext, CultureInfo.InvariantCulture);
                List<Account> accounts = User.AccountList;
                Account rekening = accounts[0];
                foreach (Account account in accounts)
                {
                    if (account.AccountNumber == mijnrekeningnr)
                    {
                        rekening = account; // give this variable the right account
                    }
                }
                rekening.TransferMoney(ontvangerrekening, bedrag);
                FormUtils.OpenForm(new ClientMainPage(User));
                OntvangerRekeningNrText.Clear();
                BedragText.Clear();             
            }          
        }

        private void MijnRekeningenDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
