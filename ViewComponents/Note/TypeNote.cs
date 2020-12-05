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
    public partial class TypeNote : UserControl
    {
        public TypeNote()
        {
            InitializeComponent();
            
        }

        private void TypeNote_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
            if (rBtnClassic.Checked == true)
                Form1.getInstance().NewNote();
            if (rBtnTodoList.Checked == true)
                Form1.getInstance().NewToDoList();
            if (rBtnReminder.Checked == true)
                Form1.getInstance().NewReminder();
        }
    }
}
