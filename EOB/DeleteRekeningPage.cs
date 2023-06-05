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
    public partial class DeleteRekeningPage : Form
    {
        private User User;
        internal DeleteRekeningPage(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void DeleteRekeningPage_Load(object sender, EventArgs e)
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

                            RekeningenDropDown.Items.Add(item);
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

        private void RekeningenDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteRekeningButton_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                string rekeningNrtext = RekeningenDropDown.Text.Replace("BE", "").Trim();
                int rekeningNr = Convert.ToInt32(rekeningNrtext);
                List<Account> accounts = User.AccountList;
                Account rekening = accounts[0];
                foreach (Account account in accounts)
                {
                    if (account.AccountNumber == rekeningNr)
                    {
                        rekening = account; // give this variable the right account
                    }
                }
                User.DeleteAccount(rekening);
                FormUtils.OpenForm(new ClientMainPage(User));
            }
        }
        private bool ValidateInputs()
        {
            string rekeningNr = RekeningenDropDown.Text.Replace("BE","").Trim();
            if (string.IsNullOrEmpty(rekeningNr))
            {
                MessageBox.Show("Please fill in all the fields!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (var item in rekeningNr)
            {
                if (!"1234567890".Contains(item))
                {
                    MessageBox.Show("Voer enkel nummers in dit veld in", "rekeningNr error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(User));
        }
    }
}
