﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOB
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public int Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Types AccountType { get; set; }
        public User User { get; set; }
        private Data _data = new Data();
        public Account(Types accountTypes,User user)
        {
            Random random = new Random();
            int accountnumber = random.Next(1000000000);
            while (_data.CheckIfAccountNumberExist(accountnumber))
            {
                Random random2 = new Random();
                accountnumber = random.Next(1000000000);
            }
            AccountNumber = accountnumber;           
            Balance = 0;
            Transactions = new List<Transaction>();
            AccountType = accountTypes;
            User = user;
        }

    }

    
}
