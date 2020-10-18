using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = G:\programming projects\Do An LTTQ\Note-Management\Data\Database.mdf; Integrated Security = True";
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
                if (passwordEncoder(acc.password).Contains(a.password) && a.username.Equals(acc.username))
                {
                    Console.WriteLine(passwordEncoder(acc.password));

                    getUserWithAccount(a);
                    recentAccount = a;
                    return true;
                }
            }
            return false;
        }
        public void getUserWithAccount(Account acc)
        {
            foreach (User u in users)
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
        public void saveAccount(Account acc)
        {
            string queryFrame = "INSERT into Accounts (Id,username,password,created,creator) VALUES (@Id,@username,@password,@created,@creator)";

            using (SqlCommand insert = new SqlCommand(queryFrame))
            {
                insert.Connection = DbConnection;
                Console.WriteLine("==========================");
                Console.WriteLine(accounts.Count());
                insert.Parameters.Add("@Id", SqlDbType.Int).Value = accounts.Count() + 10;
                insert.Parameters.Add("@username", SqlDbType.NChar).Value = acc.username;
                insert.Parameters.Add("@password", SqlDbType.NChar).Value = passwordEncoder(acc.password).Substring(0, 10);
                insert.Parameters.Add("@created", SqlDbType.DateTime).Value = DateTime.Now;/**/
                insert.Parameters.Add("@creator", SqlDbType.Int).Value = acc.creator;

                insert.ExecuteNonQuery();
            }
            populateDataFromTable("Accounts");
        }
        private string passwordEncoder(string pass)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
