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
    public partial class WordKlantPage : Form
    {
        public WordKlantPage()
        {
            InitializeComponent();
        }
        private void WordKlantPage_Load(object sender, EventArgs e)
        {
            // Set the password TextBox to display asterisks
            Password.UseSystemPasswordChar = true;
            VerifyPasswordText.UseSystemPasswordChar= true;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new Firstpage());
        }

        private void FirstName_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelLastName_Click(object sender, EventArgs e)
        {

        }

        private void LabelEmail_Click(object sender, EventArgs e)
        {

        }

        private void LabelPassword_Click(object sender, EventArgs e)
        {

        }

        private void LabelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Retrieve user input
                string firstname = FirstName.Text;

                string lastname = LastName.Text;

                string email = Email.Text;

                string password = Password.Text;

                string picturelocation = PictureLocation.Text;
                byte[] imageData = System.IO.File.ReadAllBytes(picturelocation);


                // Validate input (e.g., check for empty fields, validate email format, etc.)

                // Store the account information in the database
                Data data  = new Data();
                User user = new User(firstname, lastname,password, email,imageData);

                //        FormUtils.OpenForm(new ClientMainPage(email, password));

                // Clear the input fields
                FirstName.Clear();
                LastName.Clear();                
                Email.Clear();
                Password.Clear();
                VerifyPasswordText.Clear();
                PictureLocation.Clear();    
            }
        }

        private bool ValidateInput()
        {
            // Retrieve user input
            string firstname = FirstName.Text;
            string lastname = LastName.Text;            
            string email = Email.Text;
            string password = Password.Text;
            string verifypassword = VerifyPasswordText.Text;
            string picturelocation = PictureLocation.Text;


            // Check if any field is empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(picturelocation))
            {
                MessageBox.Show("Please fill in all the fields.");
                return false;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            // Check if the passwords are the same
            if (password != verifypassword)
            {
                MessageBox.Show("The password you filled in doesn't match");
                return false;
            }
            return true;
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

        private void ProfilePictureBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.Title = "Select Picture";
            openfiledialog1.InitialDirectory = @"C:\";
            openfiledialog1.Filter = "Pictures (*.png)|*.png|Pictures(*.jpg)|*.jpg";
            openfiledialog1.FilterIndex = 1;
            openfiledialog1.ShowDialog();
            if (openfiledialog1.FileName != "")
            {
                PictureLocation.Text = openfiledialog1.FileName;
            }
            else
            {
                PictureLocation.Text = "";
            }
        }

        private void PictureLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
