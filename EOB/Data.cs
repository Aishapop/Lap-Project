using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public int Insert(string query)
        {


            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                int result = commandDatabase.ExecuteNonQuery();
                return (int)commandDatabase.LastInsertedId;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return -1;
        }

        
        public int InsertUser(User user)
        {
            try
            {
                string query = "INSERT INTO user (Firstname,Lastname,Email,Password,ProfilePicture,Admin,Deleted) " +
               "VALUES(@Firstname, @Lastname, @Email, @Password, @ProfilePicture, @Admin, @Deleted)";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Firstname", user.Firstname);
                command.Parameters.AddWithValue("@Lastname", user.Lastname);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@ProfilePicture", user.ProfilePicture);
                command.Parameters.AddWithValue("@Admin", 0);
                command.Parameters.AddWithValue("@Deleted", 0);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return (int)command.LastInsertedId;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return -1;
        }

        public int InsertAccount(Account account,User user)
        {
            try
            {
                int type;
                if (account.AccountType.ToString() == "CurrentAccount")
                {
                     type = 1;
                }
                else
                {
                     type = 2;
                }
                string query = $"INSERT INTO rekening(Rekening_nr,SoortRekening_id,StartBedrag,User_id) " +
                    $"VALUES({account.AccountNumber},{type},{0},{user.ID});";
                                                                                                                                                                                                                                                                                                                                                                    
                return Insert(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return -1;
        }

        public bool CheckIfAccountNumberExist(int accountnumber)
        {
            string query = $"SELECT * FROM rekening WHERE Rekening_nr like {accountnumber};";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            connection.Open();
            using(MySqlDataReader reader = commandDatabase.ExecuteReader())
            {
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                connection.Close();
                if (count > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
            
            
        }


        public int InsertTransaction(Transaction transaction)
        {
            try
            {
                string query = $"INSERT INTO overschrijvingen(Bedrag,Verzender_nr,Ontvanger_nr,Datum) " +
                    $"VALUES({transaction.Amount},{transaction.FromAccount},{transaction.ToAccount},'{transaction.Date.ToString()}');";
                
                return Insert(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return -1;
        }

        public int InsertAutomaticTransaction(Account account,string startingdate,string endingdate,int amount)
        {
            try
            {
                string query = $"INSERT INTO automatic_transfer(StartDatum,Einddatum,Termijn_id,Bedrag,rekening_id) " +
                    $"VALUES('{startingdate}','{endingdate}',{1},{amount},{account.AccountNumber});";

                return Insert(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return -1;
        }

        /******UPDATE*****/

        public int UpdateUserPassword(User user, string newpassword)
        {
            string query = $"UPDATE user SET Password = '{newpassword}' WHERE id like {user.ID};";

            Insert(query);

            return -1;
        }
        public int EditUser(User user, string columnedit,string newvalue)
        {
            string query = $"UPDATE user SET {columnedit} = '{newvalue}' WHERE id like {user.ID};";

            Insert(query);

            return -1;
        }
        public int UpdateAccountToforget()
        {

            return -1;
        }

        public int DeleteAccount(Account account)
        {
            string query = $"DELETE FROM rekening WHERE Rekening_nr like {account.AccountNumber};";

            Insert(query);

            return 1;
        }
    }
}