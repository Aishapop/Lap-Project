using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOB
{
    internal class Transaction
    {
        protected int TransactionId { get; set; }
        protected Account FromAccount { get; set; }
        protected Account ToAccount { get; set; }
        protected int Amount { get; set; }
        protected DateOnly Date { get; set; }

        public Transaction()
        {

        }

    }
}
