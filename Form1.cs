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
            List<string> titles = new List<string>{ "Notes", "Account", "Settings" };
            List<string> images = new List<string> { "Notes", "Account", "Settings" };
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
                        this.navigationBar.Visible = true;
                        break;
                }
                
            }
            else
            {
                               
            }
        }
        public void setLoggedIn(bool lg)
        {
            loggedIn = lg;
            setWindow("Login");
        }
    }
}
