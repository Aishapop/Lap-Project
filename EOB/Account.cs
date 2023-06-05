using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOB
{
    internal class Account
    {

        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Types AccountType { get; set; }
        public User User { get; set; }
        private Data _data = new Data();

        //new account --> database
        public Account(Types accountTypes, User user)
        {
            //get 9 random number
            Random random = new Random();
            int accountnumber = random.Next(1000000000);
            while (_data.CheckIfAccountNumberExist(accountnumber))
            {
                accountnumber = random.Next(1000000000);
            }
            AccountNumber = accountnumber;
            Balance = 0;
            Transactions = new List<Transaction>();
            AccountType = accountTypes;
            User = user;
            _data.InsertAccount(this, user);
        }

        //new account <---- database
        public Account(int accountnr, decimal balance, Types accountTypes, User user)
        {
            AccountNumber = accountnr;
            Balance = balance;
            Transactions = _data.SelectAllTransactions(this);
            AccountType = accountTypes;
            User = user;
        }

        public decimal GetBalance()
        {
            return this.Balance;
        }
        public void TransferMoney(int accountnr,decimal amount)
        {
            
            if (this.Balance > amount)
            {

                try
                {
                    //your amount--
                    decimal yourbalance = this.Balance;
                    decimal newbalance = yourbalance - amount;
                    this.Balance = newbalance;
                    _data.UpdateBalance(this.AccountNumber, newbalance);

                    Account reciver = _data.SelectAccountBynr(accountnr);

                    //resiver amount ++
                    decimal reciverbalance = reciver.Balance;
                    decimal newbalance2 = reciverbalance + amount;
                    _data.UpdateBalance(accountnr, newbalance2);
                    reciver.Balance = newbalance2;

                    //new transaction
                    Transaction transaction = new Transaction(this, reciver, amount);
                    this.Transactions.Add(transaction);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                MessageBox.Show("Je hebt dit bedrag niet op je rekening staan", "bedrag error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DepositMoney(decimal amount)
        {
            this.Balance = this.Balance + amount;
            _data.UpdateBalance(this.AccountNumber,amount);
        }
        public List<Transaction> GetTransactionHistory()
        {
           return _data.SelectAllTransactions(this);
        }
        public void SetAutomaticTransfer(string startingdate, string termijn, string endingdate, decimal amount,int accountnr)
        {
            _data.InsertAutomaticTransaction(this,startingdate,termijn,endingdate,amount,accountnr);

            DateTime currentDate = DateTime.Parse(startingdate);
            DateTime enddate = DateTime.Parse(endingdate);

            while (currentDate <= enddate)
            {
                // Process the current date
                this.TransferMoney(accountnr, amount);

                // Move to the next date
                currentDate = currentDate.AddDays(1);
            }
        }
    } 
}
