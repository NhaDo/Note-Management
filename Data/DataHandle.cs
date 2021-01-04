using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NoteMakingApp.ViewComponents;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
        static List<MyToDoList> myTDL { get; set; }
        static List<ItemTDLs> itdl { get; set; }

        public static List<Projects> prjs { get; set; }
        static List<MyProject> mprj { get; set; }
        static List<ItemProjects> iprj { get; set; }

        static List<Reminders> rmds { get; set; }

        
        

        static User recentUser { get; set; }
        static Account recentAccount { get; set; }
        
        public static int id { get; set; }

        int idToDoList = -1;
        int idProject = -1;

        public int _isSelected = 0;
        public DataHandle()
        {
            users = new List<User>();
            accounts = new List<Account>();
            persons = new List<Person>();
            details = new List<PersonalDetail>();
            notes = new List<Notes>();

            tdls = new List<ToDoLists>();
            myTDL = new List<MyToDoList>();
            itdl = new List<ItemTDLs>();
            
            rmds = new List<Reminders>();

            prjs = new List<Projects>();
            mprj = new List<MyProject>();
            iprj = new List<ItemProjects>();
            
            recentUser = null;
            recentAccount = null;
            
            establishDbConnection();
            getData();
        }
        private void establishDbConnection()
        {

            string startupPath = System.IO.Directory.GetCurrentDirectory();
            //subtract string
            startupPath = startupPath.Substring(0, startupPath.LastIndexOf(@"\"));
            startupPath = startupPath.Substring(0, startupPath.LastIndexOf(@"\"));
            startupPath = startupPath.Substring(0, startupPath.LastIndexOf(@"\"));
            startupPath = startupPath.Substring(0, startupPath.LastIndexOf(@"\"));



            //set conn string
            //string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + startupPath + @"\Note-Management\Data\Database.mdf; Integrated Security = True";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data\Database.mdf;Integrated Security=True";

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
                case "Reminder":
                    rmds.Clear();
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
                    case "Reminder":
                        rmds.Add(new Reminders()
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Tittle = reader["Tittle"].ToString().Trim(),
                            Content = reader["Content"].ToString().Trim(),
                            Time = reader["Timer"].ToString().Trim(),
                            Check = Convert.ToInt32(reader["Checker"]),
                            User_id = Convert.ToInt32(reader["Id_User"]),
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
            try
            {
                return persons.OrderByDescending(c => c.created).ToList().First();
            }
            catch { return null; }
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
                insert.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32((DateTime.Now.Ticks << 32) >> 32);
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
            string queryFrame = "UPDATE Accounts SET password=@password WHERE Id=" + acc.id.ToString();

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


        public void EditNote(string a, string b)
        {
            int id = MainDomain.currentInstance.getFlags();
            string queryFrame = "exec USP_EditNoteByID @ID = '" + id.ToString() + "', @Tittle = N'" + a + "', @Content = N'" + b + "'";

            using (SqlCommand editNote = new SqlCommand(queryFrame))
            {
                editNote.Connection = DbConnection;
                Console.WriteLine("==========================");
                editNote.ExecuteNonQuery();
                Console.WriteLine("Da sua du lieu tai note co id " + id.ToString());
                editNote.Dispose();
            }
        }

        public void EditNoteFromPin(string a, string b)
        {
            int id = PinForm.currentInstance.getFlags();
            string queryFrame = "exec USP_EditNoteByID @ID = '" + id.ToString() + "', @Tittle = N'" + a + "', @Content = N'" + b + "'";

            using (SqlCommand editNote = new SqlCommand(queryFrame))
            {
                editNote.Connection = DbConnection;
                Console.WriteLine("==========================");
                editNote.ExecuteNonQuery();
                Console.WriteLine("Da sua du lieu tai note co id " + id.ToString());
                editNote.Dispose();
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





        public void ShowNote()
        {
            notes.Clear();
            tdls.Clear();
            rmds.Clear();
            MainDomain.currentInstance.Clear();

            populateDataFromTable("Note");
            
            foreach (Notes n in notes)
            {
                if (n.user_id == id)
                    MainDomain.currentInstance.AddNewNote(n.id, n.Tittle, n.Content);
                
            }

            GetDataFromTDL();

            foreach (ToDoLists tdl in tdls)
            {
                if (tdl.user_id == id)
                    MainDomain.currentInstance.AddNewToDoList(tdl.id.ToString(), tdl.Tittle, tdl.item);

            }

            populateDataFromTable("Reminder");

            foreach (Reminders r in rmds)
            {
                if (r.User_id == id)
                    MainDomain.currentInstance.AddReminder(r.ID.ToString(), r.Tittle, r.Content, Convert.ToDateTime(r.Time), r.Check);
                
            }

        }

        


        public void EditAvt(string AvtPath, int ID)
        {
            //image to byte []
            byte[] img = null;
            FileStream fs = new FileStream(AvtPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);

            fs.Close();
            br.Close();
            
            // get ID
            int id = ID;

            //try
            {
                /*
                string queryFrame = "exec USP_EditAvtByID @ID = '" + id.ToString() + "', @avt = '" + img + "'";
                using (SqlCommand EditAvt = new SqlCommand(queryFrame))
                {
                    EditAvt.Connection = DbConnection;
                    Console.WriteLine("==========================");
                    EditAvt.ExecuteNonQuery();
                    Console.WriteLine("avatar updated at ID: " + id.ToString());
                    EditAvt.Dispose();
                }
                */
                string queryFrame = "UPDATE Accounts SET avt = @avt WHERE Id = @ID;";
                SqlCommand EditAvt = new SqlCommand(queryFrame, DbConnection);
                EditAvt.Parameters.Add(new SqlParameter("@avt", img));
                EditAvt.Parameters.Add(new SqlParameter("@ID", id));
                EditAvt.ExecuteNonQuery();
                Console.WriteLine("avatar updated at ID: " + id.ToString());
                MessageBox.Show("successfully saved new avatar");

                EditAvt.Dispose();
            }
            /*
            catch (Exception ex)
            {
                MessageBox.Show("unable to save avt at ID : " + id.ToString());
            }
            */
        }


        public Image GetAvt(int ID)
        {
            Image Avatar = null;
            SqlCommand cmd = new SqlCommand("SELECT avt FROM Accounts WHERE Id = " + ID.ToString(), DbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                
                if ((reader[0]) == System.DBNull.Value)
                {
                    reader.Close();
                    return Avatar;
                }
                else
                {
                    byte[] img = (byte[])(reader[0]);
                    MemoryStream ms = new MemoryStream(img);
                    Avatar = Image.FromStream(ms);
                }
            }
            reader.Close();
            return Avatar;

        }




        
        public void CreateMyToDoList(string a, int b)
        {
            string queryFrame = "INSERT into MyToDoList (Tittle,id_user) VALUES (@Tittle,@id_user)";
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
        }

        public void CreateNewToDoList(string a, string b, int c,int d)
        {
            GetTittleFromToDoList();
            foreach(MyToDoList m in myTDL)
            {
                if (m.Tittle == a && m.id_user == id)
                    idToDoList = m.id;
            }
            
            string queryFrame = "INSERT into ToDoList (IDTDL,Tittle,Content,STT,Complete) VALUES (@IDTDL,@Tittle,@Content,@STT,@Complete)";

            using (SqlCommand newtdl = new SqlCommand(queryFrame))
            {
                newtdl.Connection = DbConnection;
                Console.WriteLine("==========================");
                newtdl.Parameters.Add("@IDTDL", SqlDbType.Int).Value = idToDoList;
                newtdl.Parameters.Add("@Tittle", SqlDbType.NVarChar).Value = a;
                newtdl.Parameters.Add("@Content", SqlDbType.NVarChar).Value = b;
                newtdl.Parameters.Add("@STT", SqlDbType.Int).Value = c;
                newtdl.Parameters.Add("@Complete", SqlDbType.Int).Value = d;
                newtdl.ExecuteNonQuery();
                Console.WriteLine("Nhap du lieu thanh cong");
                newtdl.Dispose();
            }
            
        }


        public void GetTittleFromToDoList()
        {
            SqlCommand cmd = new SqlCommand("Select * From MyToDoList ", DbConnection);
            tdls.Clear();
            myTDL.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                myTDL.Add(new MyToDoList()
                {
                    Tittle = reader["Tittle"].ToString().Trim(),
                    id = Convert.ToInt32(reader["id"]),
                    id_user = Convert.ToInt32(reader["id_user"]),
                });
            }
            reader.Close();
        }

        public void GetItemByTittle(string a,int b)
        {
            SqlCommand cmd = new SqlCommand("exec USP_GetItemByTittle @Tittle = N'"+a+"',@IDTDL = "+b, DbConnection);
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


        public void GetDataFromTDL()
        {
            GetTittleFromToDoList();
            foreach (MyToDoList m in myTDL)
            {
                GetItemByTittle(m.Tittle,m.id);
                tdls.Add(new ToDoLists()
                {
                    Tittle = m.Tittle,
                    item = new List<ItemTDLs>(itdl),
                    user_id = m.id_user,
                    id = m.id
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

        public void DeleteToDoList()
        {
            int id = MainDomain.currentInstance.getFlags();
            string queryFrame = "exec USP_DeleteTDLByID @ID =" + id.ToString();
            using (SqlCommand deleteTDL = new SqlCommand(queryFrame))
            {
                deleteTDL.Connection = DbConnection;
                Console.WriteLine("==========================");
                deleteTDL.ExecuteNonQuery();
                Console.WriteLine("Da xoa du lieu TDL co id " + id.ToString());
                deleteTDL.Dispose();
            }
        }

        public void DeleteItemInToDoList(string text, int stt)
        {
            string queryFrame = "exec USP_DeleteItemByTittleAndSTT @Tittle = N'" + text + "',@STT =" + stt.ToString();
            //exec USP_DeleteItemByTittleAndSTT @Tittle = N'to do list',@STT = 1;
            using (SqlCommand deleteiTDL = new SqlCommand(queryFrame))
            {
                deleteiTDL.Connection = DbConnection;
                Console.WriteLine("==========================");
                deleteiTDL.ExecuteNonQuery();
                Console.WriteLine("Da xoa du lieu iTDL " + text + " co stt " + stt.ToString());
                deleteiTDL.Dispose();
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

        


        public void CreateNewReminder(Reminders rmd)
        {
            string queryFrame = "INSERT into Reminder (Tittle,Content,Timer,Checker,Id_User) VALUES (@Tittle,@Content,@Timer,@Checker,@Id_User)";
            
            using (SqlCommand newrmd = new SqlCommand(queryFrame))
            {
                newrmd.Connection = DbConnection;
                Console.WriteLine("==========================");
                newrmd.Parameters.Add("@Tittle", SqlDbType.NVarChar).Value = rmd.Tittle;
                newrmd.Parameters.Add("@Content", SqlDbType.NVarChar).Value = rmd.Content;
                newrmd.Parameters.Add("@Timer", SqlDbType.VarChar).Value = rmd.Time;
                newrmd.Parameters.Add("@Checker", SqlDbType.Int).Value = rmd.Check;
                newrmd.Parameters.Add("@Id_User", SqlDbType.Int).Value = rmd.User_id;
                newrmd.ExecuteNonQuery();
                Console.WriteLine("Nhap du lieu thanh cong");
                newrmd.Dispose();
            }

        }

        public void EditReminder(string a, string b,string c, int d)
        {
            int id = MainDomain.currentInstance.getFlags();
            string queryFrame = "exec USP_EditReminderByID @ID = " + id.ToString() + ",@Tittle = N'" + a + "',@Content = N'" + b + "',@Time = '" + c + "',@Check = " + d + ";";

            using (SqlCommand editReminder = new SqlCommand(queryFrame))
            {
                editReminder.Connection = DbConnection;
                Console.WriteLine("==========================");
                editReminder.ExecuteNonQuery();
                Console.WriteLine("Da sua du lieu tai reminder co id " + id.ToString());
                editReminder.Dispose();
            }
        }

        public void DeleteReminder()
        {
            int id = MainDomain.currentInstance.getFlags();
            string queryFrame = "exec USP_DeleteReminder @ID = " + id.ToString();
            using (SqlCommand deleteReminder = new SqlCommand(queryFrame))
            {
                deleteReminder.Connection = DbConnection;
                Console.WriteLine("==========================");
                deleteReminder.ExecuteNonQuery();
                Console.WriteLine("Da xoa du lieu reminder co id " + id.ToString());
                deleteReminder.Dispose();
            }
        }

        public Reminders GetDateReminder()
        {
            int id = MainDomain.currentInstance.getFlags();
            foreach (Reminders r in rmds)
            {
                if (r.ID == id)
                    return r;
            }
            return null;
        }

        public bool checkTittleNote(string tittle)
        {
            foreach (Notes n in notes)
                if (n.user_id == id && n.Tittle == tittle)
                        return false;
            return true;
        }

        public bool checkTittleToDoList(string tittle)
        {
            foreach (ToDoLists t in tdls)
                if (t.Tittle == tittle && t.user_id == id)
                    return false;
            return true;
        }

        public bool checkTittleReminder(string tittle)
        {
            foreach (Reminders r in rmds)
                if (r.Tittle == tittle && r.User_id == id)
                    return false;
            return true;
        }

        public bool checkEditTittleNote(string tittle)
        {
            int check = MainDomain.currentInstance.getFlags();

            foreach (Notes n in notes)
            {
                if (n.user_id == id && n.Tittle == tittle)
                {
                    if (n.id == check)
                        return true;
                    return false;
                }
            }
            return true;
        }

        public bool checkEditTittleToDoList(string tittle)
        {
            int check = MainDomain.currentInstance.getFlags();
            foreach (ToDoLists t in tdls)
            {
                if (t.Tittle == tittle && t.user_id == id)
                {
                    if (t.id == check)
                        return true;
                    return false;
                }
            }
             return true;
        }

        public bool checkEditReminderNote(string tittle)
        {
            int check = MainDomain.currentInstance.getFlags();

            foreach (Reminders r in rmds)
            {
                if (r.User_id == id && r.Tittle == tittle)
                {
                    if (r.ID == check)
                        return true;
                    return false;
                }
            }
            return true;
        }


        public void CreateMyProject(string a, int b, string c)
        {
            string queryFrame = "INSERT into MyProject (Tittle,id_user,Deadline) VALUES (@Tittle,@id_user,@Deadline)";
            using (SqlCommand newp = new SqlCommand(queryFrame))
            {
                newp.Connection = DbConnection;
                Console.WriteLine("==========================");
                newp.Parameters.Add("@Tittle", SqlDbType.NVarChar).Value = a;
                newp.Parameters.Add("@id_user", SqlDbType.Int).Value = b;
                newp.Parameters.Add("@Deadline", SqlDbType.VarChar).Value = c;
                newp.ExecuteNonQuery();
                Console.WriteLine("Nhap du lieu thanh cong");
                newp.Dispose();
            }
        }

        public void CreateNewProject(string a, string b, int c, int d)
        {
            GetTittleFromProject();
            foreach (MyProject m in mprj)
            {
                if (m.Tittle == a && m.id_user == id)
                    idProject = m.id;
            }

            string queryFrame = "INSERT into Project (IDPJ,Tittle,Content,STT,Complete) VALUES (@IDPJ,@Tittle,@Content,@STT,@Complete)";

            using (SqlCommand newprj = new SqlCommand(queryFrame))
            {
                newprj.Connection = DbConnection;
                Console.WriteLine("==========================");
                newprj.Parameters.Add("@IDPJ", SqlDbType.Int).Value = idProject;
                newprj.Parameters.Add("@Tittle", SqlDbType.NVarChar).Value = a;
                newprj.Parameters.Add("@Content", SqlDbType.NVarChar).Value = b;
                newprj.Parameters.Add("@STT", SqlDbType.Int).Value = c;
                newprj.Parameters.Add("@Complete", SqlDbType.Int).Value = d;
                newprj.ExecuteNonQuery();
                Console.WriteLine("Nhap du lieu thanh cong");
                newprj.Dispose();
            }

        }


        public void GetTittleFromProject()
        {
            SqlCommand cmd = new SqlCommand("Select * From MyProject ", DbConnection);
            prjs.Clear();
            mprj.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                mprj.Add(new MyProject()
                {
                    Tittle = reader["Tittle"].ToString().Trim(),
                    id = Convert.ToInt32(reader["id"]),
                    id_user = Convert.ToInt32(reader["id_user"]),
                    Deadline = reader["Deadline"].ToString().Trim(),
                });
            }
            reader.Close();
        }

        public void GetItemProjectByTittle(string a, int b)
        {
            SqlCommand cmd = new SqlCommand("exec USP_GetItemProjectByTittle @Tittle = N'" + a + "',@IDPJ = " + b, DbConnection);
            iprj.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                iprj.Add(new ItemProjects()
                {
                    Content = reader["Content"].ToString().Trim(),
                    STT = Convert.ToInt32(reader["STT"]),
                    check = Convert.ToBoolean(reader["Complete"]),
                });
            }

            reader.Close();
        }


        public void GetDataFromProject()
        {
            GetTittleFromProject();
            foreach (MyProject m in mprj)
            {
                GetItemProjectByTittle(m.Tittle, m.id);
                prjs.Add(new Projects()
                {
                    Tittle = m.Tittle,
                    item = new List<ItemProjects>(iprj),
                    user_id = m.id_user,
                    id = m.id,
                    deadline = m.Deadline
                });


            }
        }

        public void EditProject(string a, List<ItemProjects> b)
        {
            int id = MainDomain.currentInstance.getFlags();
            string queryFrame = "exec USP_EditTittleProject @Tittle = N'" + a + "',@Id = " + id + "";
            using (SqlCommand editTittle = new SqlCommand(queryFrame))
            {
                editTittle.Connection = DbConnection;
                Console.WriteLine("==========================");
                editTittle.ExecuteNonQuery();
                Console.WriteLine("Da sua du lieu tai prj co id " + id.ToString());
                editTittle.Dispose();
            }

            foreach (ItemProjects i in b)
            {
                string query = "exec USP_EditContentProject @Tittle = N'" + a + "',@Content = N'" + i.Content + "',@Complete = " + Convert.ToInt32(i.check) + ",@ID = " + i.STT + "";
                using (SqlCommand editContent = new SqlCommand(query))
                {
                    editContent.Connection = DbConnection;
                    Console.WriteLine("==========================");
                    editContent.ExecuteNonQuery();
                    Console.WriteLine("Da sua du lieu tai prj co STT " + i.STT.ToString());
                    editContent.Dispose();
                }
            }

        }

        public void EditTimerProject(string time)
        {
            int id = MainDomain.currentInstance.getFlags();
            string queryFrame = "exec USP_EditTimerProject @ID = " + id.ToString() + ",@Deadline = '" + time + "'";
            using (SqlCommand edit = new SqlCommand(queryFrame))
            {
                edit.Connection = DbConnection;
                Console.WriteLine("==========================");
                edit.ExecuteNonQuery();
                Console.WriteLine("Da sua du lieu tai prj co id " + id.ToString());
                edit.Dispose();
            }

        }

        public void DeleteProject()
        {
            int id = MainDomain.currentInstance.getFlags();
            string queryFrame = "exec USP_DeleteprojectByID @ID =" + id.ToString();
            using (SqlCommand delete = new SqlCommand(queryFrame))
            {
                delete.Connection = DbConnection;
                Console.WriteLine("==========================");
                delete.ExecuteNonQuery();
                Console.WriteLine("Da xoa du lieu prj co id " + id.ToString());
                delete.Dispose();
            }
        }

        public void DeleteItemInProject(string text, int stt)
        {
            string queryFrame = "exec USP_DeleteItemProjectByTittleAndSTT @Tittle = N'" + text + "',@STT =" + stt.ToString();
            using (SqlCommand delete = new SqlCommand(queryFrame))
            {
                delete.Connection = DbConnection;
                Console.WriteLine("==========================");
                delete.ExecuteNonQuery();
                Console.WriteLine("Da xoa du lieu iPrj " + text + " co stt " + stt.ToString());
                delete.Dispose();
            }
        }

        public Projects GetDataProject()
        {
            GetDataFromProject();
            int id = MainDomain.currentInstance.getFlags();
            foreach (Projects p in prjs)
            {
                if (p.id == id)
                    return p;
            }
            return null;
        }

        public bool checkTittleProject(string tittle)
        {
            foreach (Projects t in prjs)
                if (t.Tittle == tittle && t.user_id == id)
                    return false;
            return true;
        }

        public bool checkEditTittleProject(string tittle)
        {
            int check = MainDomain.currentInstance.getFlags();
            foreach (Projects t in prjs)
            {
                if (t.Tittle == tittle && t.user_id == id)
                {
                    if (t.id == check)
                        return true;
                    return false;
                }
            }
            return true;
        }
    }

}

