using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOB
{
    internal class Admin : User
    {


        public Admin(string firstname, string lastname, string password, string email, byte[] profilepicture) : base(firstname, lastname, password, email,profilepicture)
        {

        }

        private void CreateUser()
        {

        }

        private void EditUser()
        {

        }
        private void DeleteUser()
        {

        }
        
        private void GetUserOverview()
        {

        }
    }
}
