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
    public partial class CommandBar : UserControl
    {
        public int fun;

        public CommandBar()
        {
            InitializeComponent();
        }

        private void CommandBar_Load(object sender, EventArgs e)
        {
            customButton1.setImage(0);
            customButton1.getText("New");
            
            customButton2.setImage(2);
            customButton2.getText("Edit");
            
            customButton3.setImage(4);
            customButton3.getText("Delete");
            
        }

        private void customButton1_MouseClick(object sender, MouseEventArgs e)
        {
            MainDomain mainDomain = new MainDomain();
            
        }





    }
}
