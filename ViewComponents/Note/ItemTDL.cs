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
    public partial class ItemTDL : UserControl
    {
        public ItemTDL()
        {
            InitializeComponent();
        }

        public void setValue(string text,int name, bool check)
        {
            this.textBox1.Text = text;
            this.textBox1.Name = name.ToString();
            this.checkbox.Checked = check;
            this.checkbox.Name = name.ToString();
        }

        public void edit()
        {
            this.textBox1.ReadOnly = false;
            this.checkbox.AutoCheck = true;
        }

        public void read()
        {
            this.textBox1.ReadOnly = true;
            this.checkbox.AutoCheck = false;
        }

        public void ReSize()
        {
            this.textBox1.Size = new System.Drawing.Size(200, 22);
        }
    }
}
