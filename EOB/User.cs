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

        private Data _data = new Data();

        public User(string firstname, string lastname, string password, string email, byte[] profilepicture)
        {
            Firstname = firstname;
            Lastname = lastname;
            Password = password;
            Email = email;
            ProfilePicture = profilepicture;
            ID = _data.InsertUser(this);
        }
        public User(int id,string firstname ,string lastname, string password, string email, byte[] profilepicture)
        {
            Firstname = firstname;
            Lastname = lastname;
            Password = password;
            Email = email;
            ProfilePicture = profilepicture;
            ID = id;
        }


        public User(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname= lastname;

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

        public void GetAccountOverview()
        {

        }


    }



}
