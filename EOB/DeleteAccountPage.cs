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
    public partial class DeleteAccountPage : Form
    {
        private User User;
        internal DeleteAccountPage(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void DeleteAccountPage_Load(object sender, EventArgs e)
        {

        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            data.UpdateUserToDeleted(User);
            MessageBox.Show("Your account was succesfully deleted");
            FormUtils.OpenForm(new Firstpage());
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(User));
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(User));
        }
    }
}
