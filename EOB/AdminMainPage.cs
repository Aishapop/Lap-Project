using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EOB
{
    public partial class AdminMainPage : Form
    {
        private string Email;
        private string Password;
        public AdminMainPage(string email,string password)
        {
            InitializeComponent();
            this.Email = email;
            this.Password = password;

            try
            {
                
                Data data = new Data();
                User AdminUser = data.SelectAdminIfExist(email);
            

                List<User> users = data.SelectAllUser();

                //profilepicture
                var profilepicture = AdminUser.ProfilePicture;
                               
                byte[] picture = (byte[])profilepicture;
                System.Drawing.Image image = ConvertBlobToImage(picture);
                System.Drawing.Image resizedImage = ResizeImage(image, 40, 40);

                ProfilepictureBox.Image = resizedImage;


                foreach (User user in users)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells["FirsnameColumn"].Value = user.Firstname;
                    row.Cells["LastnameColumn"].Value = user.Lastname;
                    row.Cells["EmailColumn"].Value = user.Email;

                    DataGridViewButtonCell deleteButtonCell = new DataGridViewButtonCell();
                    deleteButtonCell.Value = "Delete";
                    row.Cells["DeleteColumn"] = deleteButtonCell;


                    if (user.ProfilePicture != null)
                    {
                        System.Drawing.Image Imagepicture = ConvertBlobToImage(user.ProfilePicture);
                        System.Drawing.Image resizedImage1 = ResizeImage(Imagepicture, 100, 100);
                        row.Cells["ImageColumn"].Value = resizedImage1;
                    }
                }


                dataGridView1.CellClick += DataGridView1_CellClick;
                AdminNameLabel.Text = AdminUser.Firstname +" "+AdminUser.Lastname;
            }
            catch(Exception li)
            {
                MessageBox.Show(li.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);


            }


            


        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {
            passwordtext.UseSystemPasswordChar = true;
            passwordconfirmetext.UseSystemPasswordChar = true;
        }
        private System.Drawing.Image ResizeImage(System.Drawing.Image originalImage, int newWidth, int newHeight)
        {
            

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }
            return resizedImage;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the delete button was clicked
            if (e.ColumnIndex == dataGridView1.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                try
                {
                    Data data = new Data();
                    User AdminUser = data.SelectAdminIfExist(Email);

                    List<User> users = data.SelectAllUser();
                    // Retrieve the corresponding user and perform the delete operation
                    User user = users[e.RowIndex];
                    // Perform the delete operation for the user
                    data.UpdateUserToDeleted(user);
                    MessageBox.Show("You deleted a user", "User deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Remove the user from the DataGridView
                    dataGridView1.Rows.RemoveAt(e.RowIndex); 
                }
                catch(Exception o)
                {
                    MessageBox.Show(o.StackTrace);
                }
                
            }
        }

        


        private System.Drawing.Image ConvertBlobToImage(byte[] imageData)
        {
            // Convert the byte array into a MemoryStream
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                // Create an Image object from the MemoryStream
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                return image;
            }
        }

        bool EmailAlreadyExist(string email)
        {
            try
            {

                Data data = new Data();
                List<User> users = data.SelectAllUser();

                if(data.SelectAdminIfExist(email) != null)
                {
                    return true;
                }
                


                foreach (User user in users)
                {
                    if (user.Email == email)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return false;
        }

        bool PasswordAlreadyExist(string pw)
        {
            try
            {
                Data data = new Data();
                List<User> users = data.SelectAllUser();
                


                foreach (User user in users)
                {

                    if (user.Password == pw)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return false;
        }

        private void SelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Title = "Select Picture";
            openfiledialog1.InitialDirectory = @"C:\";
            openfiledialog1.Filter = "Pictures (*.png)|*.png|Pictures(*.jpg)|*.jpg";
            openfiledialog1.FilterIndex = 1;
            openfiledialog1.ShowDialog();
            if (openfiledialog1.FileName != "")
            {
                PictureLocation1.Text = openfiledialog1.FileName;
            }
            else
            {
                PictureLocation1.Text = "";
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email); //System.Net.Mail.MailAddress can check and return the email in the correct format.
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string HashPassword(string password) //hash a pw
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hashedPassword = Convert.ToBase64String(hashedBytes);
                return hashedPassword;
            }
        }

        private bool ValidateInput()
        {
            // Retrieve user input
            string firstname = FirstNametext.Text;
            string lastname = LastNametext.Text;
            string email = emailtext.Text;
            string password = passwordtext.Text;
            string verifypassword = passwordconfirmetext.Text;
            string picturelocation = PictureLocation1.Text;

            password = HashPassword(password);
            verifypassword = HashPassword(verifypassword);

            // Check if any field is empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(picturelocation))
            {
                MessageBox.Show("Please fill in all the fields!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (EmailAlreadyExist(email))
            {
                MessageBox.Show("this email already exist", "Email error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailtext.Clear();
                return false;
            }
            if (PasswordAlreadyExist(password))
            {
                MessageBox.Show("this password already exist", "password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordtext.Clear();
                return false;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if the passwords are the same
            if (password != verifypassword)
            {
                MessageBox.Show("The password you filled in doesn't match","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void createAccount_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidateInput())
                {
                    // Retrieve user input
                    string firstname = FirstNametext.Text;

                    string lastname = LastNametext.Text;

                    string email = emailtext.Text;

                    string password = passwordtext.Text;

                    string picturelocation = PictureLocation1.Text;
                    byte[] imageData = System.IO.File.ReadAllBytes(picturelocation);


                    // Validate input (e.g., check for empty fields, validate email format, etc.)

                    // Store the account information in the database
                    User user = new User(firstname, lastname, password, email, imageData);

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells["FirsnameColumn"].Value = user.Firstname;
                    row.Cells["LastnameColumn"].Value = user.Lastname;
                    row.Cells["EmailColumn"].Value = user.Email;

                    DataGridViewButtonCell deleteButtonCell = new DataGridViewButtonCell();
                    deleteButtonCell.Value = "Delete";
                    row.Cells["DeleteColumn"] = deleteButtonCell;


                    if (user.ProfilePicture != null)
                    {
                        System.Drawing.Image Imagepicture = ConvertBlobToImage(user.ProfilePicture);
                        System.Drawing.Image resizedImage1 = ResizeImage(Imagepicture, 100, 100);
                        row.Cells["ImageColumn"].Value = resizedImage1;
                    }
                    dataGridView1.CellClick += DataGridView1_CellClick;

                    // Clear the input fields
                    FirstNametext.Clear();
                    LastNametext.Clear();
                    emailtext.Clear();
                    passwordtext.Clear();
                    passwordconfirmetext.Clear();
                    PictureLocation1.Clear();
                }
            }
            catch(Exception st)
            {
                MessageBox.Show(st.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new Firstpage());
        }
    }

}
