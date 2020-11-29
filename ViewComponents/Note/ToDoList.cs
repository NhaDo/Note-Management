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
    public partial class ToDoList : UserControl
    {
        public ToDoList()
        {
            InitializeComponent();
            
        }

        public void setName(string a)
        {
            this.lbName.Text = a;
        }

        public void addItem(List<string> a)
        {
            foreach(string t in a)
            {
                ItemTDL i = new ItemTDL();
                i.setValue(t);
                this.flPanel.Controls.Add(i);
            }
        }
    }
}
