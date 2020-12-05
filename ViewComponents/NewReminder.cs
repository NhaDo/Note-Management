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
        
        public int _minute = 0;
        public static int User_ID;
        public NewReminder()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             int _hour = Convert.ToInt32(dateTimePicker1.Value.Hour) - DateTime.Now.Hour;
            _minute = Convert.ToInt32(dateTimePicker1.Value.Minute) - DateTime.Now.Minute;
            _minute += _hour * 60;
            Console.WriteLine(_minute);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTittle.Text == "" || _minute <  0)
                MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataHandle.getInstance().CreateNewReminder(
                    new Reminders()
                    {
                        Tittle = txtTittle.Text,
                        Content = txtContent.Text,
                        Time = _minute,
                        Check = Convert.ToInt32(checkBox.Checked),
                        User_id = User_ID
                    });
                DataHandle.getInstance().ShowNote();
                this.Dispose();
            }
        }
    }
}
