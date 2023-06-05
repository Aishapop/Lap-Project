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
    public partial class ChangePasswordPage : Form
    {
        private User User;
        internal ChangePasswordPage(User user)
        {
            InitializeComponent();
            User = user;
            OldPasswordText.UseSystemPasswordChar = true;
            NewPasswordText.UseSystemPasswordChar = true;
            VerifyNewPasswordText.UseSystemPasswordChar = true;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(User));
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            string old = OldPasswordText.Text;
            string newP = NewPasswordText.Text;
            string verify = VerifyNewPasswordText.Text;
            if (ValidateInputs())
            {
                try
                {
                    old = HashPassword(old);
                    verify = HashPassword(verify);

                    User.ChangePassword(newP);
                    MessageBox.Show("You succesfully changed your password", "Password changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormUtils.OpenForm(new Firstpage());
                    OldPasswordText.Clear();
                    NewPasswordText.Clear();
                    VerifyNewPasswordText.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool ValidateInputs()
        {
            string old = OldPasswordText.Text;
            old = HashPassword(old);
            string newP = NewPasswordText.Text;
            string verify = VerifyNewPasswordText.Text;
            if (string.IsNullOrEmpty(old) || string.IsNullOrEmpty(newP) || string.IsNullOrEmpty(verify))
            {
                MessageBox.Show("Please fill in all the fields!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(old != User.Password)
            {
                MessageBox.Show("Incorrect old password", "Old password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (verify != newP)
            {
                MessageBox.Show("The password you filled in doesn't match", "Password Doesn't match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PasswordAlreadyExist(newP))
            {
                MessageBox.Show("this password already exist", "password error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewPasswordText.Clear();
                VerifyNewPasswordText.Clear();
                return false;
            }

            return true;
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
        public static string HashPassword(string password) //hash a pw
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hashedPassword = Convert.ToBase64String(hashedBytes);
                return hashedPassword;
            }
        }
    }
}
