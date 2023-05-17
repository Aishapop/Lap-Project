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

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new Firstpage());
        }
    }
}
