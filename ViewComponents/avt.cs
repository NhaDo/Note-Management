using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteMakingApp.ViewComponents
{
    public partial class avt : UserControl
    {
        public avt()
        {
            InitializeComponent();
        }

        private void avt_MouseHover(object sender, EventArgs e)
        {
            this.bEdit.Visible = true;
        }

        private void avt_MouseLeave(object sender, EventArgs e)
        {
            this.bEdit.Visible = false;
        }
    }
}
