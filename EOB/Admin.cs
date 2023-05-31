using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOB
{
    internal class Admin : User
    {
        private Data _data = new Data();

        public Admin(string firstname, string lastname, string password, string email, byte[] profilepicture) : base(firstname, lastname, password, email,profilepicture)
        {

        }

        public void CreateUser(string firstname,string lastname,string password,string email, byte[] profilepicture)
        {
            User user = new User(firstname, lastname, password, email, profilepicture);
            _data.InsertUser(user);
        }

        public void EditUser(User user, string columnedit, string newvalue)
        {
            if (columnedit == "Firstname")
            {
                user.Firstname = newvalue;
            }
            else if (columnedit == "Lastname")
            {
                user.Lastname = newvalue;
            }
            else if (columnedit == "Email")
            {
                user.Email = newvalue;
            }
            else if (columnedit == "Password")
            {
                user.Password = newvalue;
            }

            _data.EditUser(user, columnedit, newvalue);
        }
        public void DeleteUser(User user)
        {
            user = null;
            _data.UpdateUserToDeleted(user);
        }

        public List<User> GetUserOverview()
        {
           return _data.SelectAllUser();
        }
    }
}
