using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EOB
{
    internal class Data
    {
        private string connectionString = 
            "datasource=127.0.0.1;" +
            "port=3306;" +
            "username=root;" +
            "password=root;database=eob;";
        
       public void insert()
        {
           
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
      
      
    }
}