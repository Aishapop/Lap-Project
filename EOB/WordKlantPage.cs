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
                string email = Email.Text;
                string password = Password.Text;
                string firstname = FirstName.Text;
                string lastname = LastName.Text;

                // Validate input (e.g., check for empty fields, validate email format, etc.)

                // Store the account information in the database
                // TODO: Implement database storage logic

                MessageBox.Show("Account created successfully!");

                // Clear the input fields
                Email.Clear();
                Password.Clear();
                FirstName.Clear();
                LastName.Clear();
            }
        }

        private bool ValidateInput()
        {
            // Retrieve user input
            string email = Email.Text;
            string password = Password.Text;
            string firstname = FirstName.Text;
            string lastname = LastName.Text;

            // Check if any field is empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
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
    }
}
