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
            instance = this;
        }
        public static AccountSubwindow GetInstance()
        {
            if (instance == null) 
                instance = new AccountSubwindow();
            return instance;
        }

        public static void GetPersonalDetails(int accId)
        {
            instance.personalDetailsPanel1 = PersonalDetailsPanel.getInstance(accId);
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
    }
}
