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
    public partial class NewReminder : UserControl
    {
        public static int User_ID;
        public NewReminder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTittle.Text == "")
                MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (DataHandle.getInstance().checkTittleReminder(txtTittle.Text) == false)
                MessageBox.Show("Tittle đã tồn tại!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataHandle.getInstance().CreateNewReminder(
                        new Reminders()
                        {
                            Tittle = txtTittle.Text,
                            Content = txtContent.Text,
                            Time = dateTimePicker1.Value.ToString(),
                            Check = Convert.ToInt32(checkBox.Checked),
                            User_id = User_ID
                        });
                    DataHandle.getInstance().ShowNote();
                    this.Dispose();
                }
        }
    }
}
