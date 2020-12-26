using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMakingApp.Models;

namespace NoteMakingApp.ViewComponents
{
    public partial class EditNote : UserControl
    {
        public EditNote()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTittle.Text == "")
                MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (DataHandle.getInstance().checkEditTittleNote(txtTittle.Text) == false)
                MessageBox.Show("Tittle đã tồn tại!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataHandle.getInstance().EditNote(txtTittle.Text, txtContent.Text);
                    DataHandle.getInstance().ShowNote();
                    this.Dispose();
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setValue(string b, string c)
        {
            
            this.txtTittle.Text = b;
            this.txtContent.Text = c;
        }


    }
}



