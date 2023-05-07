using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOB
{
    internal class Account
    {
        protected int AccountNumber { get; set; }
        protected int Balance { get; set; }
        protected List<Transaction> Transactions { get; set; }
        protected AccountTypes AccountType { get; set; }
        protected User User { get; set; }


    }
}
