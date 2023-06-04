using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void ReturnButton_Click(object sender, EventArgs e)
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
                User userData = data.SelectUSerIfExist(email);
                try
                {
                    password = HashPassword(password);
                }
                catch(Exception d)
                {
                    MessageBox.Show(d.Message);
                }
                if (userData == null)
                {
                    MessageBox.Show("Incorrect Email, Try again", "Incorrect email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if(email == userData.Email && password == userData.Password)
                {
                    FormUtils.OpenForm(new ClientMainPage(email));
                    EmailText.Clear();
                    PasswordText.Clear();
                }
                else
                {
                    MessageBox.Show("Incorrect Password, Try again", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private bool ValidateInput()
        {
            string email = EmailText.Text;
            string password = PasswordText.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all the fields!","Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address","Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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

        private void AanmeldPage_Load(object sender, EventArgs e)
        {

        }
    }
}
