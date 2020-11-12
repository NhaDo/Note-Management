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
    public partial class EditionItem : UserControl
    {
        public int function = -1;
        public bool isGeneralDetail;
        public PersonalDetail originDetail;
        public EditionItem()
        {
            InitializeComponent();
        }
        public EditionItem(PersonalDetail dt, bool general, bool addition=false)
        {
            InitializeComponent();
            this.lbSubcategory.Text = dt.subcategory;
            this.lbConent.Text = dt.content;
            this.originDetail = dt;
            isGeneralDetail = general;
            if (!isGeneralDetail)
            {
                switch (originDetail.category)
                {
                    case "Contact":
                        cbSubcatgory.Items.Add("Facebook");
                        cbSubcatgory.Items.Add("Gmail");
                        cbSubcatgory.Items.Add("Instagram");
                        cbSubcatgory.Items.Add("Phone");
                        break;
                    case "Detail":
                        cbSubcatgory.Items.Add("Education");
                        cbSubcatgory.Items.Add("Achievements");
                        cbSubcatgory.Items.Add("Address");
                        break;
                }
                if(addition) function++;
                setFunctionView();
            }
            else
            {
                lbSubcategory.Text = dt.subcategory;
            }
            
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            setFunctionView();

            
        }
        private void setFunctionView()
        {
            function = (function + 1) % 3;
            if (isGeneralDetail && function == 1) function = 2;
            btnFunction.Text = function.ToString();
            switch (function)
            {
                // Nonfunctional
                case 0:
                case 1:
                    lbConent.Visible = true;
                    lbSubcategory.Visible = true;
                    cbSubcatgory.Visible = false;
                    tbContent.Visible = false;
                    break;
                // Modify/Add item
                case 2:
                    lbConent.Visible = false;
                    tbContent.Visible = true;
                    if (!isGeneralDetail)
                    {
                        lbSubcategory.Visible = false;
                        cbSubcatgory.Visible = true;
                        cbSubcatgory.SelectedItem = originDetail.subcategory;
                    }
                    break;
            }
        }
        public PersonalDetail generateDetail()
        {
            return new PersonalDetail() {
                account = originDetail.account,
                category = originDetail.category,
                subcategory = cbSubcatgory.SelectedItem.ToString(),
                content = tbContent.Text,
            };
        }
        public NoteMakingApp.Models.Account GetAccount()
        {
            return new NoteMakingApp.Models.Account()
            {
                id = originDetail.account,
                password = tbContent.Text,
            };
        }
        public string GetContent() { return tbContent.Text; }
        public PersonalDetail getOriginalDetail()
        {
            return originDetail;
        }
    }
}
