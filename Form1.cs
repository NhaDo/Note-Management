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

namespace NoteMakingApp
{
    public partial class Form1 : Form
    {
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
                        break;
                    case "ACCOUNT":
                        this.accountSubwindow2.Visible = true;
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
            newNote.setValue(a,b,c);
            this.Controls.Add(newNote);
            newNote.BringToFront();
        }

        public void editNote(string a = "Edit note", string b = null, string c = null)
        {
            EditNote editNote = new EditNote();
            editNote.Location = new System.Drawing.Point(400, 100);
            editNote.setValue(a, b, c);
            this.Controls.Add(editNote);
            editNote.BringToFront();
        }
    } 
}
