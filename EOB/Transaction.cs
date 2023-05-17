using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOB
{
    internal class Transaction
    {
        public int ID { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }

        private Data _data = new Data();

        public Transaction(Account fromaccount, Account toaccount, int amount)
        {
            //new transaction is directly add in account list
            fromaccount.Transactions.Add(this);
            FromAccount = fromaccount.AccountNumber;
            ToAccount = toaccount.AccountNumber;
            Amount = amount;
            //bij elke nieuwe transactie 
            Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ID = _data.InsertTransaction(this);
        }

    }
}
