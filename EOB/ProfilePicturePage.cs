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
    public partial class ProfilePicturePage : Form
    {
        private User User;
        internal ProfilePicturePage(User user)
        {
            InitializeComponent();
            User = user;
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

        private void ChangeProfilePicButton_Click(object sender, EventArgs e)
        {
            string profilepicturelocation = PictureLocation.Text;
            byte[] imageData = System.IO.File.ReadAllBytes(profilepicturelocation);
            if (!string.IsNullOrEmpty(profilepicturelocation))
            {
                User.ChangeProfilePicture(imageData);
                MessageBox.Show("Profile picture succesfully changed","succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormUtils.OpenForm(new ClientMainPage(User));
                PictureLocation.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(User));
        }
    }
}
