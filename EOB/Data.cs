﻿using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOB
{
    internal class Data
    {


        private string connectionString =
            "datasource=127.0.0.1;" +
            "port=3306;" +
            "username=root;" +
            "password=root;" +
            "database=eob;";



        /******INSERT******/
        public int Insert(string query)
        {


            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                
                return (int)commandDatabase.LastInsertedId;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                
            }
            return -1;
        }

        
        public int InsertUser(User user)
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
            try
            {                                             
                connection.Open();
                int result = command.ExecuteNonQuery();
                return (int)command.LastInsertedId;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
            return -1;
        }
        public int InsertAccount(Account account,User user)
        {
            try
            {
                string query = "";
                if (account.AccountType.ToString() == "Zichtrekening")
                {
                    query = $"INSERT INTO rekening(Rekening_nr,SoortRekening_id,StartBedrag,User_id) " +
                    $"VALUES({account.AccountNumber},{3},{0},{user.ID});";
                }
                else if (account.AccountType.ToString() == "Spaarrekening")
                {
                    query = $"INSERT INTO rekening(Rekening_nr,SoortRekening_id,StartBedrag,User_id) " +
                    $"VALUES({account.AccountNumber},{4},{0},{user.ID});";
                }
                else
                {
                    MessageBox.Show("Not a valid AccountType", "Invalid AccountType", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            int count = 0;
            try
            {
                connection.Open();
                using (MySqlDataReader reader = commandDatabase.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        count++;
                    }
                    

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
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
        public int InsertAutomaticTransaction(Account verzenderaccount,string startingdate,string termijn, string endingdate,decimal amount, int ontvangerrekeningNR)
        {
            try
            {
                if(termijn == "wekelijks")
                {
                    string query = $"INSERT INTO automatic_transfer(StartDatum,Einddatum,Termijn_id,Bedrag,Verzender_id,Ontvanger_id) " +
                    $"VALUES('{startingdate}','{endingdate}',{1},{amount},{verzenderaccount.AccountNumber},{ontvangerrekeningNR});";
                    return Insert(query);
                }
                else if(termijn == "maandelijks")
                {
                    string query = $"INSERT INTO automatic_transfer(StartDatum,Einddatum,Termijn_id,Bedrag,Verzender_id,Ontvanger_id) " +
                    $"VALUES('{startingdate}','{endingdate}',{2},{amount},{verzenderaccount.AccountNumber},{ontvangerrekeningNR});";
                    return Insert(query);
                }
                else if(termijn == "jaarlijks")
                {
                    string query = $"INSERT INTO automatic_transfer(StartDatum,Einddatum,Termijn_id,Bedrag,Verzender_id,Ontvanger_id) " +
                    $"VALUES('{startingdate}','{endingdate}',{3},{amount},{verzenderaccount.AccountNumber},{ontvangerrekeningNR});";
                    return Insert(query);
                }
                else
                {
                    MessageBox.Show("Het ingevoerde termijn is geen optie");
                }                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        public int UpdateProfilePicture(User user, byte[] profilepicture)
        {

            string query = $"UPDATE user SET ProfilePicture = '{profilepicture}' WHERE id like {user.ID};";

            Insert(query);

            return -1;
        }
        public int EditUser(User user, string columnedit,string newvalue)
        {
            //edit option (firtname,lastname,email,password)
            string query = $"UPDATE user SET {columnedit} = '{newvalue}' WHERE id like {user.ID};";

            Insert(query);

            return -1;
        }

        public int EditUserProfilepicture(User user, byte[] newvalue)
        {
            string query = "UPDATE user SET ProfilePicture = @ProfilePicture WHERE id = @UserID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProfilePicture", newvalue);
                    command.Parameters.AddWithValue("@UserID", user.ID);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        return -1;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public int UpdateUserToDeleted(User user)
        {

            string query = $"UPDATE user SET Deleted = 1 WHERE id like {user.ID};";

            Insert(query);

            return -1;
        }

        public int UpdateUserToRemoveDeleted(User user)
        {

            string query = $"UPDATE user SET Deleted = 0 WHERE id like {user.ID};";

            Insert(query);

            return -1;
        }
        public int UpdateBalance(int rekeningnr, decimal amount)
        {
            string query = $"UPDATE rekening SET StartBedrag = {amount} WHERE Rekening_nr LIKE {rekeningnr};";

            Insert(query);

            return -1;
        }
        

        /*******SELECT*****/
        public User SelectUSerIfExist(string email)

        {
            
            string query = $"SELECT* FROM user WHERE Email LIKE '{email}' AND Deleted LIKE 0;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.Read())
                {                                      
                    int id = reader.GetInt32(0);
                    string firstname = reader.GetString(1);
                    string lastname = reader.GetString(2);
                    string email1 = reader.GetString(3);
                    string password1 = reader.GetString(4);
                    var profilepicture = reader.GetValue(5);

                    return new User(id, firstname, lastname, password1, email1, (byte[])profilepicture);
                }
                else
                {
                    return null;
                }

            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
                
            }
            return null;
        }
        public User SelectUSerWhenDeletedIfExist(string email)

        {

            string query = $"SELECT* FROM user WHERE Email LIKE '{email}' AND Deleted LIKE 1;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string firstname = reader.GetString(1);
                    string lastname = reader.GetString(2);
                    string email1 = reader.GetString(3);
                    string password = reader.GetString(4);
                    var profilepicture = reader.GetValue(5);

                    return new User(id, firstname, lastname, password, email1, (byte[])profilepicture);
                }
                else
                {
                    MessageBox.Show("User still exists");
                    return null;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();

            }
        }

        public User SelectAdminIfExist(string email)

        {

            string query = $"SELECT* FROM user WHERE Email LIKE '{email}' AND Admin LIKE 1;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string firstname = reader.GetString(1);
                    string lastname = reader.GetString(2);
                    string email1 = reader.GetString(3);
                    string password1 = reader.GetString(4);
                    var profilepicture = reader.GetValue(5);
                    

                    return new User(id, firstname, lastname, password1, email1, (byte[])profilepicture);
                }
                else
                {
                    return null;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();

            }
            return null;
        }
        public Account SelectAccountBynr(int accountnumer)
        {
            string query = $"SELECT * FROM rekening INNER JOIN user on user.id = rekening.User_id WHERE Rekening_nr LIKE {accountnumer};";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    int accountnr = (int)reader.GetInt32(0);
                    int soortrekening = (int)reader.GetInt32(1);
                    decimal balance = (decimal)reader.GetDecimal(2);
                    string email = reader.GetString(7);
                    string pw = reader.GetString(8);

                    User user = SelectUSerIfExist(email);
                    List<Transaction> transactions = new List<Transaction>();   
                    if (soortrekening == 3)
                    {
                        Account account = new Account(accountnr, balance, Types.Zichtrekening, user);
                        return account;
                    }
                    else if (soortrekening == 4)
                    {
                        Account account = new Account(accountnr, balance, Types.Spaarrekening, user);
                        return account;
                    }

                }
                else
                {
                    return null;
                }

            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
            return null;
        }

        public List<Transaction> SelectAllTransactions(Account account)
        {
            string query = $"SELECT * FROM overschrijvingen WHERE Verzender_nr LIKE '{account.AccountNumber}';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<Transaction> transactionslist = new List<Transaction>();

                while (reader.Read())
                {

                    int id = (int)reader.GetInt32(0);
                    decimal amount = (decimal)reader.GetDecimal(1);
                    int sender = (int)reader.GetInt32(2);
                    int reciver = (int)reader.GetInt32(3);

                    Account accountreciver = SelectAccountBynr(reciver);

                    Transaction transaction = new Transaction(account, accountreciver, amount, id);
                    transactionslist.Add(transaction);

                }
                return transactionslist;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }



        }
        public List<Account> SelectAllAccount(User user)
        {
            if (user == null)
            {
                MessageBox.Show("user is null");
                return null;
            } 
            string query = $"SELECT * FROM rekening WHERE User_id LIKE '{user.ID}';";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<Account> accountslist = new List<Account>();

                while (reader.Read())
                {
                   
                    int accountnr = (int)reader.GetInt32(0);
                    int soortrekening = (int)reader.GetInt32(1);
                    
                    decimal balance = (decimal)reader.GetDecimal(2);
                    
                    
                    if (soortrekening == 3)
                    {
                        Account account = new Account(accountnr, balance, Types.Zichtrekening, user);
                        accountslist.Add(account);
                    }
                    else if (soortrekening == 4)
                    {
                        Account account = new Account(accountnr, balance, Types.Spaarrekening,user);
                        accountslist.Add(account);
                    }
                    

                }
                return accountslist;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            finally
            {
                connection.Close();
            }

            return null;
           
        }

        public List<User> SelectAllUser()
        {
            
            string query = $"SELECT * FROM user WHERE Deleted LIKE 0 AND Admin LIKE 0;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<User> userslist = new List<User>();

                while (reader.Read())
                {

                    int id = (int)reader.GetInt32(0);
                    string firstname = (string)reader.GetString(1);
                    string lastname = (string)reader.GetString(2);
                    string email = (string)reader.GetString(3);
                    string password = (string)reader.GetString(4);
                    var profilepicture = reader.GetValue(5);

                    User user = new User(id, firstname, lastname, password, email, (byte[])profilepicture);
                    userslist.Add(user);

                }
                return userslist;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return null;
        }

        /******DELETE******/
        public int DeleteAccount(Account account)
        {
            string query0 = $"DELETE FROM overschrijvingen WHERE Verzender_nr LIKE {account.AccountNumber} OR Ontvanger_nr LIKE {account.AccountNumber};";
            string query = $"DELETE FROM rekening WHERE Rekening_nr like {account.AccountNumber};";

            Insert(query0);
            Insert(query);
            
            return 1;
        }

    }
}