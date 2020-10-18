using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMakingApp.Models;

namespace NoteMakingApp.ViewComponents
{
    public partial class LoginPanel : UserControl
    {

        public LoginPanel()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {

            if (checkInputs() >= 0)
            {
                Account acc = new Account()
                {
                    username = iUsername.Text,
                    password = iPassword.Text                    
                };
                if (checkData(acc))
                {
                    Console.WriteLine("login step");
                    Form1.getInstance().setLoggedIn(true);
                    Form1.IDname =  acc.username; // here
                }
            }

        }
        private bool checkData(Account acc)
        {
            if (DataHandle.getInstance().doesAccountExit(acc))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int checkInputs()
        {
            int isGood = 1;
            if (iUsername.Text == null || iUsername.Text == "")
            {
                isGood = -1;
                eUsername.Visible = true;
                eUsername.Text = "Your username is inappropriate";
            }
            if (iPassword.Text == null || iUsername.Text == "")
            {
                isGood = -1;
                ePassword.Visible = true;
                ePassword.Text = "Your password is inappropriate";
            }
            return isGood;
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            Form1.getInstance().setWindow("Register");
        }
    }
}
