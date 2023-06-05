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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EOB
{
    public partial class HistoryTransactionsPage : Form
    {
        private User User;
        internal HistoryTransactionsPage(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void HistoryTransactionsPage_Load(object sender, EventArgs e)
        {
            List<Account> accounts = User.AccountList;
            foreach(Account account in accounts)
            {
                List<Transaction> transactions = account.GetTransactionHistory();
                foreach(Transaction transaction in transactions)
                {
                    ListViewItem item = new ListViewItem("BE" + transaction.FromAccount.ToString());
                    item.SubItems.Add("BE" + transaction.ToAccount.ToString());
                    item.SubItems.Add("€" + transaction.Amount.ToString());
                    item.SubItems.Add(transaction.Date.ToString());

                    HistoryOfTransactionsListView.Items.Add(item);
                }
            }
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

                            MijnrekeningNrDropDown.Items.Add(item);
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

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(User));
        }

        private void HistoryOfTransactionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MijnrekeningNrDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string filterText = MijnrekeningNrDropDown.Text;
            /*
            // Loop through the items and show/hide based on the filter text
            foreach (ListViewItem item in listView1.Items)
            {
                bool match = false;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(filterText))
                    {
                        match = true;
                        break;
                    }
                }
                item.Selected = match;
                item.EnsureVisible();
            }
            */
        }
    }
}
