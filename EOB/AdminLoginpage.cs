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
    public partial class AdminLoginpage : Form
    {
        public AdminLoginpage()
        {
            InitializeComponent();
            PasswordText.UseSystemPasswordChar = true;

        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new Firstpage());
        }

        private bool ValidateInput()
        {
            string email = EmailText.Text;
            string password = PasswordText.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all the fields!","Empty fields",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address","Email not valid",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        public static string HashPassword(string password) //hash a pw
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hashedPassword = Convert.ToBase64String(hashedBytes);
                return hashedPassword;
            }
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string email = EmailText.Text;
                string password = PasswordText.Text;

                try
                {
                    password = HashPassword(password);
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.Message);
                }

                Data data = new Data();
                User AdminUser = data.SelectAdminIfExist(email);
                
                if (AdminUser == null)
                {
                    MessageBox.Show("Incorrect Email or Password, Try again","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                }
                else if (email == AdminUser.Email && password == AdminUser.Password)
                {
                    FormUtils.OpenForm(new AdminMainPage(email, password));
                    EmailText.Clear();
                    PasswordText.Clear();
                }

                else
                {
                    MessageBox.Show("Something went wrong","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }
    }
}
