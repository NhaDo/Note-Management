﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NoteMakingApp.ViewComponents;

namespace NoteMakingApp.Models
{
    public class DataHandle
    {
        private static DataHandle instance;
        private static SqlConnection DbConnection;
        static List<User> users { get; set; }
        static List<Account> accounts { get; set; }
        static List<Person> persons { get; set; }
        static List<PersonalDetail> details { get; set; }
        static List<Notes> notes { get; set; }
        static List<ToDoLists> tdls { get; set; }
        static List<ItemTDLs> itdl { get; set; }
        static List<string> _Tittle { get; set; }
        static List<string> _Content { get; set; }
        
        static User recentUser { get; set; }
        static Account recentAccount { get; set; }
        static Notes recentNote { get; set; }
        public static int id { get; set; }
        public int _isSelected = 0;
        public int _idtdl = 0;
        public int _idUsertdl = 0;
        public DataHandle()
        {
            users = new List<User>();
            accounts = new List<Account>();
            persons = new List<Person>();
            details = new List<PersonalDetail>();
            notes = new List<Notes>();
            tdls = new List<ToDoLists>();
            itdl = new List<ItemTDLs>();
            _Tittle = new List<string>();
            _Content = new List<string>();
            recentUser = null;
            recentAccount = null;
            recentNote = null;
            establishDbConnection();
            getData();
        }
        private void establishDbConnection()
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Project\Note-Management1\Data\Database.mdf; Integrated Security = True";
            DbConnection = new SqlConnection(connectionString);
            DbConnection.Open();
            Console.WriteLine("Opened data connection");

        }
        private void populateDataFromTable(string tableName, int account = -1)
        {
  
            SqlCommand cmd = new SqlCommand("Select * from " + tableName, DbConnection);
            switch (tableName)
            {
                case "Accounts":
                    accounts.Clear();
                    break;
                case "Persons":
                    persons.Clear();
                    break;
                case "PersonalDetails":
                    details.Clear();
                    break;
                case "Note":
                    notes.Clear();
                    break;
                
                    
            }
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
                    case "Persons":
                        if (Convert.ToInt32(reader["account"]) == account)
                            persons.Add(new Person()
                            {
                                id = Convert.ToInt32(reader["Id"]),
                                account = Convert.ToInt32(reader["account"]),
                                name = reader["name"].ToString().Trim(),
                                introduction = reader["introduction"].ToString().Trim(),
                                created = Convert.ToDateTime(reader["created"].ToString()),
                            });
                        break;
                    case "PersonalDetails":
                        if(Convert.ToInt32(reader["person"]) == account && Convert.ToInt32(reader["usable"]) !=0)
                            details.Add(new PersonalDetail()
                            {
                                id = Convert.ToInt32(reader["Id"]),
                                account = Convert.ToInt32(reader["person"]),
                                category = reader["category"].ToString().Trim(),
                                subcategory = reader["subcategory"].ToString().Trim(),
                                content = reader["content"].ToString().Trim(),
                            });
                        break;
                    case "Note":
                        notes.Add(new Notes()
                        {
                            id = Convert.ToInt32(reader["ID"]),
                            Tittle = reader["Tittle"].ToString().Trim(),
                            Content = reader["Content"].ToString().Trim(),
                            user_id = Convert.ToInt32(reader["Id_User"]),
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
                if (passwordEncoder(acc.password).Contains(a.password) && a.username.Equals(acc.username)) // anhPhuc comment passswordencoder !?!?!????
                {
                    if(a.username.Equals(acc.username))
                        Console.WriteLine(passwordEncoder(acc.password));

                    getUserWithAccount(a);
                    acc.id = a.id;
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
        public List<Account> GetAccounts()
        {
            return accounts;
        }
        
        public Account getRecentAccount() {
            /*
            if (recentAccount == null)
            {
                doesAccountExit(new Account()
                {
                    username="phuc",
                    password= "phuc",
                });
            }
            */
            return recentAccount; }
        public Person GetPerson(int account)
        {
            populateDataFromTable("Persons", account);
            return persons.OrderByDescending(c => c.created).ToList().First();
        }
        public List<PersonalDetail> GetDetails(int account)
        {
            populateDataFromTable("PersonalDetails", account);
            return details;
        }
        public void deleteDetail(PersonalDetail dt)
        {
            string delete = "UPDATE PersonalDetails SET usable=" + 0.ToString()+" WHERE Id=" +dt.id.ToString();
            SqlCommand command = new SqlCommand(delete);
            command.Connection = DbConnection;
            command.ExecuteNonQuery();
        }
        public void createDetail(PersonalDetail dt)
        {
            string queryFrame = "INSERT INTO PersonalDetails (Id, person, category, subcategory, content, usable) " +
                                    "VALUES (@Id, @person, @category, @subcategory, @content, @usable)";
            using (SqlCommand insert = new SqlCommand(queryFrame))
            {
                insert.Connection = DbConnection;
                insert.Parameters.Add("@Id", SqlDbType.Int).Value = DateTime.Now.Ticks;
                insert.Parameters.Add("@person", SqlDbType.Int).Value = dt.account;
                insert.Parameters.Add("@category", SqlDbType.NChar, 20).Value = dt.category;
                insert.Parameters.Add("@subcategory", SqlDbType.Char, 20).Value = dt.subcategory;
                insert.Parameters.Add("@usable", SqlDbType.Int).Value = 1;/**/
                insert.Parameters.Add("@content", SqlDbType.Text).Value = dt.content;
                insert.ExecuteNonQuery();
            }
        }
        public void updateDetail(PersonalDetail origin, PersonalDetail update)
        {
            deleteDetail(origin);
            createDetail(update);
        }
        public void UpdatePerson(Person per)
        {
            string queryFrame = "UPDATE Persons SET name = @name, introduction=@introduction, created=@created WHERE Id=@Id" ;
            using (SqlCommand update = new SqlCommand(queryFrame))
            {
                update.Connection = DbConnection;
                update.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = per.id;
                update.Parameters.AddWithValue("@name", SqlDbType.Text).Value = per.name;
                update.Parameters.AddWithValue("@introduction", SqlDbType.Text).Value = per.introduction;
                update.Parameters.AddWithValue("@created", SqlDbType.DateTime).Value = DateTime.Now;/**/
                update.ExecuteNonQuery();
            }
        }
        public void UpdateAccount(Account acc)
        {
            string queryFrame = "UPDATE PersonalDetails (password) " +
                                    "VALUES (@password) WHERE Id=" + acc.id.ToString();
            using (SqlCommand update = new SqlCommand(queryFrame))
            {
                update.Connection = DbConnection;
                update.Parameters.Add("@password", SqlDbType.NChar, 10).Value = passwordEncoder(acc.password).Substring(0, 10); ;
                update.ExecuteNonQuery();
            }
        }


        public void CreateNewNote(Notes nt)
        {
            string queryFrame = "INSERT into Note (Tittle,Content,Id_User) VALUES (@Tittle,@Content,@Id_User)";

            using (SqlCommand newNote = new SqlCommand(queryFrame))
            {
                newNote.Connection = DbConnection;
                Console.WriteLine("==========================");
                newNote.Parameters.Add("@Tittle", SqlDbType.NVarChar).Value = nt.Tittle;
                newNote.Parameters.Add("@Content", SqlDbType.NVarChar).Value = nt.Content;
                newNote.Parameters.Add("@Id_User", SqlDbType.Int).Value = nt.user_id;
                newNote.ExecuteNonQuery();
                Console.WriteLine("Nhap du lieu thanh cong");
                newNote.Dispose();
            }
        }

        public void ShowNote()
        {
            notes.Clear();
            tdls.Clear();
            MainDomain.currentInstance.Clear();
            GetDataFromTDL();
            
            foreach (ToDoLists tdl in tdls)
            {
                if (tdl.user_id == id)
                    MainDomain.currentInstance.AddNewToDoList(tdl.id.ToString(), tdl.Tittle, tdl.item);
                
            }
            

            populateDataFromTable("Note");
            
            foreach (Notes n in notes)
            {
                if (n.user_id == id)
                    MainDomain.currentInstance.AddNewNote(n.id, n.Tittle, n.Content);
            }
        }

        public void DeleteNote()
        {
            int id = MainDomain.currentInstance.getFlags();
         

          
            string queryFrame = "exec USP_DeleteNoteByID @ID = " + id.ToString();
            using (SqlCommand deleteNote = new SqlCommand(queryFrame))
            {
                deleteNote.Connection = DbConnection;
                Console.WriteLine("==========================");
                deleteNote.ExecuteNonQuery();
                Console.WriteLine("Da xoa du lieu note co id " + id.ToString());
                deleteNote.Dispose();
            }
        }

        public void EditNote(string a,string b)
        {
            int id = MainDomain.currentInstance.getFlags();
            string queryFrame = "exec USP_EditNoteByID @ID = '"+ id.ToString() +"', @Tittle = N'" +a+ "', @Content = N'" + b+ "'" ;
            
            using (SqlCommand deleteNote = new SqlCommand(queryFrame))
            {
                deleteNote.Connection = DbConnection;
                Console.WriteLine("==========================");
                deleteNote.ExecuteNonQuery();
                Console.WriteLine("Da sua du lieu tai note co id " + id.ToString());
                deleteNote.Dispose();
            }
        }

        public Notes GetDataFromNote()
        {
            int id = MainDomain.currentInstance.getFlags();
            foreach (Notes n in notes)
            {
                if (n.id == id)
                    return n;
            }
            return null;
        }

        public void CreateNewToDoList(string a, string b, int c,int d)
        {
            
            string queryFrame = "INSERT into ToDoList (Tittle,Content,STT,Complete) VALUES (@Tittle,@Content,@STT,@Complete)";

            using (SqlCommand newtdl = new SqlCommand(queryFrame))
            {
                newtdl.Connection = DbConnection;
                Console.WriteLine("==========================");
                newtdl.Parameters.Add("@Tittle", SqlDbType.NVarChar).Value = a;
                newtdl.Parameters.Add("@Content", SqlDbType.NVarChar).Value = b;
                newtdl.Parameters.Add("@STT", SqlDbType.Int).Value = c;
                newtdl.Parameters.Add("@Complete", SqlDbType.Int).Value = d;
                newtdl.ExecuteNonQuery();
                Console.WriteLine("Nhap du lieu thanh cong");
                newtdl.Dispose();
            }
            
        }

        public void CreateMyNote(string a, int b)
        {
            string queryFrame = "INSERT into MyNote (Tittle,id_user) VALUES (@Tittle,@id_user)";

            using (SqlCommand newt = new SqlCommand(queryFrame))
            {
                newt.Connection = DbConnection;
                Console.WriteLine("==========================");
                newt.Parameters.Add("@Tittle", SqlDbType.NVarChar).Value = a;
                newt.Parameters.Add("@id_user", SqlDbType.Int).Value = b;
                newt.ExecuteNonQuery();
                Console.WriteLine("Nhap du lieu thanh cong");
                newt.Dispose();
            }
            ;


        }

        public void GetTittleFromToDoList()
        {
            SqlCommand cmd = new SqlCommand("Select Distinct Tittle From ToDoList ", DbConnection);
            tdls.Clear();
            _Tittle.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _Tittle.Add(reader["Tittle"].ToString().Trim());
            }
            reader.Close();
        }

        public void GetItemByTittle(string a)
        {
            SqlCommand cmd = new SqlCommand("exec USP_GetItemByTittle @Tittle = N'"+a+"'", DbConnection);
            itdl.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                itdl.Add(new ItemTDLs()
                {
                    Content = reader["Content"].ToString().Trim(),
                    STT = Convert.ToInt32(reader["STT"]),
                    check = Convert.ToBoolean(reader["Complete"]),
                });
            }
            
            reader.Close(); 
        }

        public void GetUserIdByTittle(string a)
        {
            SqlCommand cmd = new SqlCommand("exec USP_GetIdByTittle @Tittle = N'" + a + "'", DbConnection);
            
            _idtdl = 0;
            _idUsertdl = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _idUsertdl = Convert.ToInt32(reader["id_user"]);
                _idtdl = Convert.ToInt32(reader["id"]);
            }
            
            reader.Close();
        }

        public void GetDataFromTDL()
        {
            _Tittle.Clear();
            GetTittleFromToDoList();
      
            foreach (string t in _Tittle)
            {
                GetItemByTittle(t);
                GetUserIdByTittle(t);
                
                tdls.Add(new ToDoLists()
                {
                    Tittle = t,
                    item = new List<ItemTDLs>(itdl),
                    user_id = _idUsertdl,
                    id = _idtdl
                });
                
               
            }
        }

        public void EditToDoList(string a, List<ItemTDLs> b)
        {
            int id = MainDomain.currentInstance.getFlags();
            string queryFrame = "exec USP_EditTittleTDL @Tittle = N'" + a + "',@Id = " + id + "";
            using (SqlCommand editTittle = new SqlCommand(queryFrame))
            {
                editTittle.Connection = DbConnection;
                Console.WriteLine("==========================");
                editTittle.ExecuteNonQuery();
                Console.WriteLine("Da sua du lieu tai tdl co id " + id.ToString());
                editTittle.Dispose();
            }

            foreach (ItemTDLs i in b)
            {
                string query = "exec USP_EditContentTDL @Tittle = N'" + a + "',@Content = N'" + i.Content + "',@Complete = " + Convert.ToInt32(i.check) + ",@ID = " + i.STT + "";
                using (SqlCommand editContent = new SqlCommand(query))
                {
                    editContent.Connection = DbConnection;
                    Console.WriteLine("==========================");
                    editContent.ExecuteNonQuery();
                    Console.WriteLine("Da sua du lieu tai tdl co STT " + i.STT.ToString());
                    editContent.Dispose();
                }
            }

        }

        public ToDoLists GetDataToDoList()
        {
            int id = MainDomain.currentInstance.getFlags();
            foreach (ToDoLists t in tdls)
            {
                if (t.id == id)
                    return t;
            }
            return null;
        }
    }
}

