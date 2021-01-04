using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMakingApp.ViewComponents.AccountVC;
using NoteMakingApp.Models;

namespace NoteMakingApp.ViewComponents
{
    public partial class AccountSubwindow : UserControl
    {
        private static AccountSubwindow instance;
        public AccountSubwindow()
        {
            InitializeComponent();
            instance=this;
        }
        public static AccountSubwindow GetInstance()
        {
            if (instance == null) 
                instance = new AccountSubwindow();
            return instance;
        }

        public static void GetPersonalDetails(int accId)
        {
            GetInstance().personalDetailsPanel1 = PersonalDetailsPanel.getInstance(accId);
        }
        public static void GenerateInformationEditor(string cat, List<PersonalDetail> dts, Person per)
        {
            instance.informationEditor1 = InformationEditor.getInstance(DataHandle.getInstance().getRecentAccount().id, cat, dts, per);
            instance.informationEditor1.Visible = true;
        }
        public static void EraseInformationEditor()
        {
            instance.informationEditor1.Visible = false;
            instance.personalDetailsPanel1.UpdateContent();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            if(Connection.clientStatus == -1)
            {
                MessageBox.Show("No connection is found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (Connection.clientStatus == 0)
            {
                Models.Account rct = DataHandle.getInstance().getRecentAccount();
                Form1.connection.DistributeAccount(rct, DataHandle.getInstance().GetDetails(rct.id));
            } else
            {
                Models.Account rct = DataHandle.getInstance().getRecentAccount();
                Form1.connection.CSendAccount(rct, DataHandle.getInstance().GetDetails(rct.id));
            }
            
        }
        delegate void SetAccountList();

        public void UpdateAccountList()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.accountList1.InvokeRequired)
            {
                SetAccountList d = new SetAccountList(UpdateAccountList);
                this.Invoke(d, new object[] {});
            }
            else
            {
                this.accountList1.populateAccounts();
            }
        }
    }
}
