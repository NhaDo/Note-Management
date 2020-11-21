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
    public partial class Note : UserControl
    {
        public Note()
        {
            InitializeComponent();
        }

        public void setTittle(string text)
        {
            this.lbTittle.Text = text;
        }

        public void setContent(string text)
        {
            this.lbContent.Text = text;
        }
    }
}
