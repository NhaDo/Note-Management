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
using NoteMakingApp.ViewComponents.Account;

namespace NoteMakingApp.ViewComponents
{
    public partial class AccountList : UserControl
    {
        private bool increasingOrder = true;
        public AccountList()
        {
            InitializeComponent();
            populateAccounts();
        }


        public void populateAccounts()
        {
            List<NoteMakingApp.Models.Account> accounts = DataHandle.getInstance().GetAccounts();
            switch (cbOrder.SelectedItem)
            {
                case "Created":
                    accounts.OrderBy(a => a.created).ToList();
                    break;
                case "Username":
                default:
                    accounts.OrderBy(a => a.username).ToList();
                    break;

            }
            accounts = accounts.FindAll(a => a.username.Contains(tbSearch.Text));
            if (!increasingOrder) accounts.Reverse();

            this.pnlList.Controls.Clear();
            AccountListItem item;
            foreach (NoteMakingApp.Models.Account a in accounts)
            {
                item = new AccountListItem(a, accounts.IndexOf(a) + 1);
                item.Location = new System.Drawing.Point(0, this.pnlList.Controls.Count * item.Height);
                this.pnlList.Controls.Add(item);
            }
        }
        private void bReverse_Click(object sender, EventArgs e)
        {
            increasingOrder = false;
            populateAccounts();
        }

        private void cbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateAccounts();
        }
        private void bSearch_Click(object sender, EventArgs e)
        {
            populateAccounts();
        }
    }
}
