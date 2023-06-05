using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private User User;
        internal ClientMainPage(User user) 
        {
            InitializeComponent();
            this.User = user;
        }

        private void ProfilePicturePictureBox_Click(object sender, EventArgs e)
        {
            DropDownMenuOfPfp.Show(ProfilePicturePictureBox, new Point(0, ProfilePicturePictureBox.Height));
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
            byte[] picture = User.ProfilePicture;
            // Convert the blob data into an image
            Image image = ConvertBlobToImage(picture);
            // Assign the converted image to the PictureBox control
            ProfilePicturePictureBox.Image = image;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new RectangleF(0, 0, ProfilePicturePictureBox.Width, ProfilePicturePictureBox.Height));
            ProfilePicturePictureBox.Region = new Region(path);

            // Set the PictureBox background to transparent
            ProfilePicturePictureBox.BackColor = Color.Transparent;
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

        private void automatischToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new AutomatischeOverschrijvingPage(User));
        }

        private void OverschrijvingenDropdownMenu_Click(object sender, EventArgs e)
        {
            DropDownMenuOfOverschrijvingen.Show(OverschrijvingenDropdownMenu, new Point(0, OverschrijvingenDropdownMenu.Height));
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new Firstpage());
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new DepositPage(User));
        }

        private void normaalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new NormaleOverschrijvingPage(User));
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new DeleteAccountPage(User));
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ChangePasswordPage(User));
        }
    }
}
