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
    public partial class RecoverAccountPage : Form
    {
        public RecoverAccountPage()
        {
            InitializeComponent();
        }

        private void RecoverAccountButton_Click(object sender, EventArgs e)
        {
            string email = EmailText.Text;

            Data data = new Data();
            User user = data.SelectUSerWhenDeletedIfExist(email);
            data.UpdateUserToRemoveDeleted(user);
            MessageBox.Show("Account has been recovered");
            FormUtils.OpenForm(new Firstpage());
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new Firstpage());
        }

        private void RecoverAccountPage_Load(object sender, EventArgs e)
        {

        }
    }
}
