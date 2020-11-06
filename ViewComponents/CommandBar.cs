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
        public CommandBar()
        {
            InitializeComponent();
        }

        private void CommandBar_Load(object sender, EventArgs e)
        {
            customButton1.getImage("C:/Users/seled/Desktop/Note-Management/Resources/add.png");
            customButton1.getText("New");
            customButton2.getImage("C:/Users/seled/Desktop/Note-Management/Resources/edit.png");
            customButton2.getText("Edit");
            customButton3.getImage("C:/Users/seled/Desktop/Note-Management/Resources/delete.png");
            customButton3.getText("Delete");
        }

        private void customButton2_Load(object sender, EventArgs e)
        {

        }
    }
}
