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
    public partial class NewNote : UserControl
    {
        

        public NewNote()
        {
            InitializeComponent();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTittle.Text == "")
                MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MainDomain.currentInstance.AddNewNote(txtTittle.Text,txtContent.Text);
            }
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
