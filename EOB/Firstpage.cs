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
    public partial class Firstpage : Form
    {
        public Firstpage()
        {
            InitializeComponent();
        }

        private void Firstpage_Load(object sender, EventArgs e)
        {

        }

        private void wordKlantButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new WordKlantPage());
        }

        private void aanmeldButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new AanmeldPage());
        }

        private void adminButton_Click(object sender, EventArgs e)
        {

        }
    }
}
