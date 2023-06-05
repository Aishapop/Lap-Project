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
    public partial class HistoryTransactionsPage : Form
    {
        private User User;
        internal HistoryTransactionsPage(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void HistoryTransactionsPage_Load(object sender, EventArgs e)
        {
            List<Account> accounts = User.AccountList;
            foreach(Account account in accounts)
            {
                List<Transaction> transactions = account.GetTransactionHistory();
                foreach(Transaction transaction in transactions)
                {
                    ListViewItem item = new ListViewItem("BE" + transaction.FromAccount.ToString());
                    item.SubItems.Add("BE" + transaction.ToAccount.ToString());
                    item.SubItems.Add("€" + transaction.Amount.ToString());
                    item.SubItems.Add(transaction.Date.ToString());

                    HistoryOfTransactionsListView.Items.Add(item);
                }
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(User));
        }

        private void HistoryOfTransactionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            MijnrekeningNrDropDown.Show(MijnrekeningNrDropDown, new Point(0, MijnrekeningNrDropDown.Height));
        }
    }
}
