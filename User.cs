using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOB
{
    internal class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        protected string Password { get; set; }
        protected string Email { get; set; }


        public User(string firstname, string lastname, string password, string email)
        {
            Firstname = firstname;
            Lastname = lastname;
            Password = password;
            Email = email;
        }
        public void CreateAccount()
        {

        }

        public void Login()
        {

        }

        public void ChangePassword()
        {

        }

        public void DeleteAccount()
        {

        }

        public void UploadProfilePicture()
        {

        }

        public void GetAccountOverview()
        {

        }


    }

      

}
