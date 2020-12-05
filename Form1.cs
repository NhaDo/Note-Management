
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

namespace NoteMakingApp
{
    public partial class Form1 : Form
    {
        public static int type = 0;
        static private bool loggedIn = false;
        private static Form1 instance;
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
            List<string> titles = new List<string> { "HOME", "ACCOUNT", "SETTINGS" };
            List<string> images = new List<string> { "HOME.png", "ACCOUNT.png", "SETTINGS.png" };
            this.navigationBar.addNavOptions(titles, images);
           
            instance = this;
            setWindow();
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
                        this.navigationBar.Show();
                        this.mainDomain1.Show();
                        this.accountSubwindow2.Visible = false;
                        DataHandle.getInstance().ShowNote();
                        break;
                    case "ACCOUNT":
                        this.accountSubwindow2.Visible = true;
                        this.mainDomain1.Hide();
                        break;
                    case "HOME":
                        this.mainDomain1.Show();
                        this.accountSubwindow2.Visible = false;
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

        public void editToDoList(string name,List<ItemTDLs> item)
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

        public void ShowTypeNote()
        {
            TypeNote typeNote = new TypeNote();
            typeNote.Location = new System.Drawing.Point(300, 80);
            this.Controls.Add(typeNote);
            typeNote.BringToFront();
        }
    }
}