using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOB
{
    public partial class ClientMainPage : Form
    {
        private string Email;
        private string Password;
        public ClientMainPage()//ClientMainPage(string email, string password) 
        {
            InitializeComponent();
            //Email = email;
            //Password = password;
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            User user = data.SelectUSerIfExist(Email,Password);
            byte[] picture = user.ProfilePicture;
            MemoryStream memoryStream = new MemoryStream(picture);
            Image image = Image.FromStream(memoryStream);

            ProfilePicture.Image = image;
        }

        private void Spaarrekeningen_Click(object sender, EventArgs e)
        {

        }

        private void BalanceOfZichtrekeningLabel_Click(object sender, EventArgs e)
        {
            

        }
    }
}
