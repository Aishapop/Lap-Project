using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EOB
{
    public partial class ClientMainPage : Form
    {
        private string Email;
        private string Password;
        public ClientMainPage(string email, string password) 
        {
            InitializeComponent();
            this.Email = email;
            this.Password = password;
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            User user = data.SelectUSerIfExist(Email,Password);
            byte[] picture = user.ProfilePicture;
            // Convert the blob data into an image
            Image image = ConvertBlobToImage(picture);
            // Assign the converted image to the PictureBox control
            ProfilePicturePictureBox.Image = image;
            ProfilePicturePictureBox.Refresh();
        }
        private Image ConvertBlobToImage(byte[] imageData)
        {
            // Convert the byte array into a MemoryStream
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                // Create an Image object from the MemoryStream
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void Spaarrekeningen_Click(object sender, EventArgs e)
        {

        }

        private void ClientMainPage_Load(object sender, EventArgs e)
        {
            // Establish a connection to the MySQL database
            string connectionString =
            "datasource=127.0.0.1;" +
            "port=3306;" +
            "username=root;" +
            "password=root;" +
            "database=eob;";

            MySqlConnection connection = new MySqlConnection(connectionString);

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
                Data data = new Data();
                User user = data.SelectUSerIfExist(Email, Password);

                // Iterate over the data and populate the ListView control
                foreach (DataRow row in dataTable.Rows)
                {
                    if (Convert.ToInt32(row["User_id"]) == user.ID)
                    {
                        if (Convert.ToInt32(row["SoortRekening_id"]) == 1)
                        {
                            ListViewItem item = new ListViewItem(row["Rekening_nr"].ToString());
                            item.SubItems.Add(row["StartBedrag"].ToString());

                            ZichtrekeningBalancesListView.Items.Add(item);
                        }
                        else if (Convert.ToInt32(row["SoortRekening_id"]) == 2)
                        {
                            ListViewItem item = new ListViewItem(row["Rekening_nr"].ToString());
                            item.SubItems.Add(row["StartBedrag"].ToString());

                            SpaarrekeningBalancesListView.Items.Add(item);
                        }
                    }
                }
            }
            catch(Exception ex)
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

        private void ZichtrekeningBalancesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SpaarrekeningBalancesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SpaarrekeningHistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void ZichtrekeningHistoryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
