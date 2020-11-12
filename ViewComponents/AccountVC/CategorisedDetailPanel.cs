using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using NoteMakingApp.Models;

namespace NoteMakingApp.ViewComponents.AccountVC
{
    public partial class CategorisedDetailPanel : UserControl
    {
        public List<PersonalDetail> details;
        public CategorisedDetailPanel()
        {
            InitializeComponent();
        }
        public CategorisedDetailPanel(string cat, List<PersonalDetail> details, bool own)
        {
            InitializeComponent();
            this.pnlDetails.Controls.Clear();
            this.lbCategory.Text = cat;
            if (!own) this.btnEdit.Visible = false;
            DetailItem item;
            this.details = details;
            foreach(PersonalDetail dt in details)
            {
                item = new DetailItem(dt.subcategory, dt.content);
                item.Location = new System.Drawing.Point(0, this.pnlDetails.Controls.Count * item.Size.Height);
                this.pnlDetails.Controls.Add(item);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AccountSubwindow.GenerateInformationEditor(this.lbCategory.Text, this.details, null);
        }
    }
}
