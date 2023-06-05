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
    public partial class MyAccountsOverviewPage : Form
    {
        private User User;
        internal MyAccountsOverviewPage(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(User));
        }

        private void MyAccountsOverviewPage_Load(object sender, EventArgs e)
        {
            // Establish a connection to the MySQL database
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
                            if (Convert.ToInt32(row["SoortRekening_id"]) == 1)
                            {
                                ListViewItem item = new ListViewItem("BE" + row["Rekening_nr"].ToString());
                                item.SubItems.Add("");
                                item.SubItems.Add("€" + row["StartBedrag"].ToString());

                                RekeningBalancesListView.Items.Add(item);
                            }
                            else if (Convert.ToInt32(row["SoortRekening_id"]) == 2)
                            {
                                ListViewItem item = new ListViewItem("");
                                item.SubItems.Add("BE" + row["Rekening_nr"].ToString());
                                item.SubItems.Add("€" + row["StartBedrag"].ToString());

                                RekeningBalancesListView.Items.Add(item);
                            }
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
    }
}
