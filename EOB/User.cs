using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EOB
{
    internal class User
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public byte[] ProfilePicture { get; set; }
        public List<Account> AccountList { get; set; }

        private Data _data = new Data();

        // new user ---> database
        public User(string firstname, string lastname, string password, string email, byte[] profilepicture)
        {
            Firstname = firstname;
            Lastname = lastname;
            Password = password;
            Email = email;
            ProfilePicture = profilepicture;
            ID = _data.InsertUser(this);
            AccountList = new List<Account>();
        }
        // new user <--- database
        public User(int id,string firstname ,string lastname, string password, string email, byte[] profilepicture)
        {
            Firstname = firstname;
            Lastname = lastname;
            Password = password;
            Email = email;
            ProfilePicture = profilepicture;
            ID = id;
            AccountList = _data.SelectAllAccount(this);
        }

        //new user for tests
        public User(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname= lastname;

        }
        public void CreateAccount(Types type)
        {
            Account account = new Account(type,this);
            this.AccountList.Add(account);
        }

        public User Login()
        {
            try
            {
               return _data.SelectUSerIfExist(this.Email, this.Password);
            }
            catch
            {
                return null;
            }
        }

        public void ChangePassword(string Newpw)
        {
            _data.UpdateUserPassword(this, Newpw);
        }

        public void DeleteAccount(Account account)
        {
            _data.DeleteAccount(account);
        }

        public void GetAccountOverview()
        {
            _data.SelectAllAccount(this);
        }


    }



}
