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

namespace NoteMakingApp.ViewComponents.AccountVC
{
    public partial class PersonalDetailsPanel : UserControl
    {
        Person person;
        int account;
        private static PersonalDetailsPanel instance;
        public PersonalDetailsPanel()
        {
            InitializeComponent();
            instance = this;
        }
        public static PersonalDetailsPanel getInstance(int acc)
        {
            if (instance == null) instance = new PersonalDetailsPanel();
            instance.account = acc;
            instance.person = DataHandle.getInstance().GetPerson(acc);
            instance.lbName.Text= instance.person.name;
            instance.lbIntroduction.Text = instance.person.introduction;
            instance.btnEdit.Visible = false;

            List<PersonalDetail> details = DataHandle.getInstance().GetDetails(acc);
            List<PersonalDetail> categorisedDetails;
            CategorisedDetailPanel categoryPanel;
            instance.pnlCategories.Controls.Clear();
            foreach (string c in PersonalDetail.categories)
            {
                categorisedDetails = details.FindAll(d => d.category == c);
                if (categorisedDetails.Count != 0)
                {
                    categoryPanel = new CategorisedDetailPanel(c, categorisedDetails, acc == 57/*DataHandle.getInstance().getRecentAccount().id*/);
                    categoryPanel.Location = new System.Drawing.Point(0,
                        instance.pnlCategories.Controls.Count == 0 ? 0 :
                        instance.pnlCategories.Controls[instance.pnlCategories.Controls.Count - 1].Location.Y +
                        instance.pnlCategories.Controls[instance.pnlCategories.Controls.Count - 1].Size.Height);
                    instance.pnlCategories.Controls.Add(categoryPanel);
                }
                
            }
            instance.PerformLayout();
            instance.Refresh();
            return instance;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AccountSubwindow.GenerateInformationEditor("General", null, person);
        }
        public void UpdateContent()
        {
            getInstance(account);
        }
    }
}
