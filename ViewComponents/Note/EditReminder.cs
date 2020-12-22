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
    public partial class EditReminder : UserControl
    {
        public EditReminder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void SetValue(string Tittle,string Content, string time, int check)
        {
            txtTittle.Text = Tittle;
            txtContent.Text = Content;
            dateTimePicker1.Value = Convert.ToDateTime(time);
            checkBox.Checked = Convert.ToBoolean(check);
            int i = 0;
            DateTime t = Convert.ToDateTime(time);
            i = ((t.Hour - DateTime.Now.Hour) * 3600 + (t.Minute - DateTime.Now.Minute) * 60) * 1000;
            if ((t.Day - DateTime.Now.Day) < 0)
                i = 0;
            if (i <= 0)
                checkBox.Checked = false;
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTittle.Text == "")
                MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataHandle.getInstance().EditReminder(txtTittle.Text, txtContent.Text,dateTimePicker1.Value.ToString(),Convert.ToInt16(checkBox.Checked));
                DataHandle.getInstance().ShowNote();
                this.Dispose();
            }
        }
    }
}
