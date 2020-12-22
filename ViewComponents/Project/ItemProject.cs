using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteMakingApp.ViewComponents.Project
{
    public partial class ItemProject : UserControl
    {
        public ItemProject()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void setValue(int Name, string Text, bool check)
        {
            label1.Name = Name.ToString();
            label1.Text = Text;
            checkBox1.Checked = check;
            checkBox1.AutoCheck = false;
        }
    }
}
