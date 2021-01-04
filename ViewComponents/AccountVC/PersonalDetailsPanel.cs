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
            this.Visible = true;
            this.btnEdit.Visible = false;
            instance = this;
        }
        public static PersonalDetailsPanel getInstance(int acc)
        {
            if (instance == null) instance = new PersonalDetailsPanel();
            instance.account = acc;
            instance.person = DataHandle.getInstance().GetPerson(acc);
            if (instance.person != null)
            {
                instance.lbName.Text = instance.person.name;
                instance.lbIntroduction.Text = instance.person.introduction;
            }
            else
            {
                instance.lbName.Text = "";
                instance.lbIntroduction.Text = "";
            }
            instance.btnEdit.Visible = acc == DataHandle.getInstance().getRecentAccount().id;

            List<PersonalDetail> details = DataHandle.getInstance().GetDetails(acc);
            List<PersonalDetail> categorisedDetails;
            CategorisedDetailPanel categoryPanel;
            instance.pnlCategories.Controls.Clear();
            bool nodetails = true;
            foreach (string c in PersonalDetail.categories)
            {
                categorisedDetails = details.FindAll(d => d.category == c);
                
                    categoryPanel = new CategorisedDetailPanel(c, categorisedDetails, acc == DataHandle.getInstance().getRecentAccount().id);
                    categoryPanel.Location = new System.Drawing.Point(0,
                        instance.pnlCategories.Controls.Count == 0 ? 0 :
                        instance.pnlCategories.Controls[instance.pnlCategories.Controls.Count - 1].Location.Y +
                        instance.pnlCategories.Controls[instance.pnlCategories.Controls.Count - 1].Size.Height);
                    instance.pnlCategories.Controls.Add(categoryPanel);
                if (categorisedDetails.Count != 0) nodetails = false;
            }
            if(instance.person==null && nodetails)
            {
                instance.label1.Visible = true;
            }else
            {
                instance.label1.Visible = false;

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
