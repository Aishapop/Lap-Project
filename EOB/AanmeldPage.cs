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
    public partial class AanmeldPage : Form
    {
        public AanmeldPage()
        {
            InitializeComponent();
            PasswordText.UseSystemPasswordChar = true;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new Firstpage());
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                string email = EmailText.Text;
                string password = PasswordText.Text;

                Data data = new Data();
                User userData = data.SelectUSerIfExist(email, password);
                if(userData == null)
                {
                    MessageBox.Show("Incorrect Email or Password, Try again");
                }
                else if(email == userData.Email && password == userData.Password)
                {
                    FormUtils.OpenForm(new ClientMainPage(email, password));
                    EmailText.Clear();
                    PasswordText.Clear();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            
        }
        private bool ValidateInput()
        {
            string email = EmailText.Text;
            string password = PasswordText.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all the fields!");
                return false;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address");
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
        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
