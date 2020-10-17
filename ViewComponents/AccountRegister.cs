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
    public partial class AccountRegister : UserControl
    {
        public AccountRegister()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (checkUsername() && checkPassword() && checkConfirmation())
            {
                DataHandle.getInstance().saveAccount(
                    new Account()
                    {
                        username = iUsername.Text,
                        password = iPassword.Text,
                        creator = 0
                    });
                nullifyField();
                Form1.getInstance().setWindow("Login");
            }

        }
        private void nullifyField()
        {
            iUsername.Text = "";
            iPassword.Text = "";
            iConfirmation.Text = "";
            eConfirmation.Visible = false;
            ePassword.Visible = false;
            eUser.Visible = false;
        }
        private bool checkUsername()
        {
            return true;
        }
        private bool checkPassword()
        {
            return true;
        }
        private bool checkConfirmation()
        {
            if (iConfirmation.Text != iPassword.Text)
            {
                eConfirmation.Visible = true;
                return false;
            }
            return true;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Form1.getInstance().setWindow("Login");
        }
    }
}
