using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteMakingApp.ViewComponents.Account
{
    public partial class AccountListItem : UserControl
    {
        public static Size size = new System.Drawing.Size(209,31);
        private NoteMakingApp.Models.Account account;
        public AccountListItem()
        {
            InitializeComponent();
        }
        public AccountListItem(NoteMakingApp.Models.Account acc, int index)
        {
            InitializeComponent();
            this.account = acc;
            this.lbIndex.Text = index.ToString();
            this.lbUsername.Text = acc.username;
            this.lbCreated.Text = acc.created.ToString();
            size = this.Size;
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            AccountSubwindow.GetPersonalDetails(account.id);
        }
    }
}
