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
    public partial class EditItem : UserControl
    {
        public EditItem()
        {
            InitializeComponent();
        }

        public void setValue(int name,string text,bool check)
        {
            this.textBox.Name = name.ToString();
            this.textBox.Text = text;
            this.checkBox.Checked = check;
        }
    }
}
