using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteMakingApp.Models
{
    public class DataHandle
    {
        private static DataHandle instance;
        private static SqlConnection DbConnection;
        static List<User> users { get; set; }
        static List<Account> accounts { get; set; }
        static User recentUser { get; set; }
        static Account recentAccount { get; set; }
        public DataHandle()
        {
            users = new List<User>();
            accounts = new List<Account>();
            recentUser = null;
            recentAccount = null;

            establishDbConnection();
            getData();
        }
        private void establishDbConnection()
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ngoho\source\repos\NoteMakingApp\Data\Database.mdf; Integrated Security = True";
            DbConnection = new SqlConnection(connectionString);
            DbConnection.Open();
            Console.WriteLine("Opened data connection");
            
        }
        private void populateDataFromTable(string tableName)
        {
            SqlCommand cmd = new SqlCommand("Select * from " + tableName, DbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                switch (tableName)
                {
                    case "Accounts":
                        accounts.Add(new Account()
                        {
                            id = Convert.ToInt32(reader["Id"]),
                            username = reader["username"].ToString().Trim(),
                            password = reader["password"].ToString().Trim(),
                            created = Convert.ToDateTime(reader["created"].ToString()),
                            creator = Convert.ToInt32(reader["creator"])
                        });
                        break;
                }
            }
            reader.Close();
        }
        public static void closeDbConnection()
        {
            if (DbConnection.State != ConnectionState.Closed)
            {
                DbConnection.Close();
                Console.WriteLine("Closed data connection");
            }

        }
        public static DataHandle getInstance()
        {
            if (instance == null)
            {
            
                instance = new DataHandle();

            }
            return instance;
        }
        public void getData()
        {
            populateDataFromTable("Accounts");
        }
        public bool doesAccountExit(Account acc)
        {
            foreach (Account a in accounts)
            {
                if (a.password.Equals(acc.password) && a.username.Equals(acc.username))
                {
                    getUserWithAccount(a);
                    recentAccount = a;
                    return true;
                }
            }
            return false;
        }
        public void getUserWithAccount(Account acc)
        {
            foreach(User u in users)
            {
                if (u.account.Equals(acc))
                {
                    recentUser = u;
                }
            }
        }
        public void nullifyRecentInfo()
        {
            recentUser = null;
            recentAccount = null;
        }
    }
}
