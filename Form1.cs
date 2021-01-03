
using NoteMakingApp.ViewComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMakingApp.Models;
using NoteMakingApp.ViewComponents.Note;
using NoteMakingApp.ViewComponents.Project;


namespace NoteMakingApp
{
    public partial class Form1 : Form
    {
        List<PinForm> Pin_List= new List<PinForm>();
        public static int type = 0;
        static private bool loggedIn = false;
        private static Form1 instance;

        private  static int ID;
        public static Connection connection;

        private System.Windows.Forms.Timer status;
        public static void setID(int login_ID)
        {
            ID = login_ID;
        }

        public static int getID()
        {
            return ID;
        }
        static public Form1 getInstance()
        {
            if (instance == null)
            {
                instance = new Form1();
            }
            return instance;
        }

        public Form1()
        {
            InitializeComponent();
            status =new System.Windows.Forms.Timer();
            status.Tick += status_Tick;
            status.Interval = 1000;
            

            List<string> titles = new List<string> { "HOME", "ACCOUNT", "SETTINGS" };
            List<string> images = new List<string> { "HOME", "ACCOUNT", "SETTINGS1" };
            this.navigationBar.addNavOptions(titles, images);
            instance = this;
            setWindow();
            connection = new Connection();

            //xu ly closing form
            instance.FormClosed += new FormClosedEventHandler(FormClosed2);

        }

        static void FormClosed2(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed2;
            if (Application.OpenForms.Count == 0)

                Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed2;
        }

        public static void ShowAvtEditor()
        {
            instance.avatarEditor1.setID(ID);
            instance.avatarEditor1.Visible = true;
            instance.avatarEditor1.BringToFront();
            instance.avatarEditor1.Focus();
        }


        public static void UpdateAvt()
        {
            instance.navigationBar.avatar.Image = instance.avatarEditor1.avt;
        }

        public void setWindow(string option = "")
        {
            if (loggedIn == true)
            {
                Console.WriteLine(option);
                switch (option)
                {
                    case "Login":
                        this.loginPanel1.Hide();
                        this.navigationBar.username.Text = IDname;
                        this.navigationBar.setID(ID);
                        this.navigationBar.Show();
                        this.mainDomain1.Show();
                        this.accountSubwindow2.Visible = false;
                        DataHandle.getInstance().ShowNote();
                        this.navigationBar.LoadAvt(DataHandle.getInstance().GetAvt(ID));
                        break;
                    case "Logout":
                        this.loginPanel1.Show();
                        this.navigationBar.Hide();
                        this.mainDomain1.Hide();
                        this.accountSubwindow2.Visible = false;
                        this.networkSubWindow1.Visible = false;
                        DataHandle.getInstance().ShowNote();
                        this.navigationBar.LoadAvt(DataHandle.getInstance().GetAvt(ID));
                        break;
                    case "ACCOUNT":
                        this.accountSubwindow2.Visible = true;
                        networkSubWindow1.Visible = false;

                        this.mainDomain1.Hide();
                        break;
                    case "HOME":
                        this.mainDomain1.Show();
                        networkSubWindow1.Visible = false;
                        this.accountSubwindow2.Visible = false;
                        networkSubWindow1.Visible = false;

                        break;
                    case "SETTINGS":
                        networkSubWindow1.Visible = true;
                        this.accountSubwindow2.Visible = false;

                        this.mainDomain1.Hide();
                        break;
                }
            }
            else
            {
                switch (option)
                {
                    case "Login":
                        this.registerPanel.Hide();
                        this.loginPanel1.Show();
                        break;
                    case "Register":
                        this.loginPanel1.Hide();
                        this.registerPanel.Show();
                        break;
                }

            }
        }
        public void setLoggedIn(bool lg)
        {
            loggedIn = lg;
            setWindow("Login");
        }
        public static string IDname;

        public void NewNote(string a = "New note", string b = null, string c = null)
        {
            NewNote newNote = new NewNote();
            newNote.Location = new System.Drawing.Point(400, 100);
            this.Controls.Add(newNote);
            newNote.BringToFront();
        }

        public void editNote(string b = null, string c = null)
        {
            EditNote editNote = new EditNote();
            editNote.Location = new System.Drawing.Point(400, 100);
            editNote.setValue(b, c);
            this.Controls.Add(editNote);
            editNote.BringToFront();
        }

        public void NewToDoList()
        {
            NewToDoList newtodo = new NewToDoList();
            newtodo.Location = new System.Drawing.Point(390, 80);
            this.Controls.Add(newtodo);
            newtodo.BringToFront();
        }

        public void editToDoList(string name, List<ItemTDLs> item)
        {
            EditToDoList editTDL = new EditToDoList();
            editTDL.Location = new System.Drawing.Point(400, 100);
            editTDL.setValue(name, item);
            this.Controls.Add(editTDL);
            editTDL.BringToFront();
        }

        public void NewReminder()
        {
            NewReminder newrmd = new NewReminder();
            newrmd.Location = new System.Drawing.Point(370, 120);
            this.Controls.Add(newrmd);
            newrmd.BringToFront();
        }

        public void EditReminder(string Tittle, string Content, string time, int check)
        {
            EditReminder editReminder = new EditReminder();
            editReminder.Location = new System.Drawing.Point(400, 100);
            editReminder.SetValue(Tittle, Content, time, check);
            this.Controls.Add(editReminder);
            editReminder.BringToFront();
        }

        public void ShowTypeNote()
        {
            TypeNote typeNote = new TypeNote();
            typeNote.Location = new System.Drawing.Point(300, 80);
            this.Controls.Add(typeNote);
            typeNote.BringToFront();
        }

        public void NewProject()
        {
            NewProject newProject = new NewProject();
            newProject.Location = new System.Drawing.Point(370, 80);
            this.Controls.Add(newProject);
            newProject.BringToFront();
        }

        public void ShowListProject()
        {
            ListProject lp = new ListProject();
            lp.Location = new System.Drawing.Point(310, 35);
            lp.Size = new System.Drawing.Size(110, 165);
            this.Controls.Add(lp);
            lp.BringToFront();
        }

        public void ShowProject(string nameProject, List<ItemProjects> item, string complete, string time)
        {
            Project prj = new Project();
            prj.Location = new System.Drawing.Point(360, 80);
            prj.setValue(nameProject, item);
            
            if (time != "no timer")
            {
                prj.setValueTimer(time);
                prj.setDeadline(time);
                prj.Timer.Enabled = true;
                prj.showTime();
                prj.Timer.Tick += (s, e) =>
                {
                    prj.setDeadline(time);
                };
                
            }
            this.Controls.Add(prj);
            prj.BringToFront();
            prj.setComplete(complete);
        }

        private void status_Tick(object sender, EventArgs e)
        {
            status.Stop();
            this.connectionStatus.Visible = false;
        }
        delegate void SetConnectionstatus(string stt);

        public void UpdateConnectionStatus(string stt)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.connectionStatus.InvokeRequired)
            {
                SetConnectionstatus d = new SetConnectionstatus(UpdateConnectionStatus);
                this.Invoke(d, new object[] {stt});
            }
            else
            {
                this.connectionStatus.Text = stt;
                this.connectionStatus.Visible = true;
                status.Start();
            }
        }
    }
}