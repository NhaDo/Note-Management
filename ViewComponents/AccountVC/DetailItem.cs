using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteMakingApp.ViewComponents.AccountVC
{
    public partial class DetailItem : UserControl
    {
        public DetailItem()
        {
            InitializeComponent();
        }
        public DetailItem(string subcat, string cont)
        {
            InitializeComponent();
            this.lbSubcategory.Text = subcat;
            this.lbContent.Text = cont;
        }
    }
}
