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
    public partial class Timer : UserControl
    {
        public static string time = null;
        public Timer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            time = DatePicker.Value.ToShortDateString() + " " + TimePicker.Value.ToShortTimeString();
            if (checkTime(time))
            {
                Project.email = this.textBox1.Text;
                Console.WriteLine(Project.email);
                NewProject._timer = 1;
                Project._timer = 1;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại thời gian", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        public bool checkTime(string time)
        {
            DateTime _time = Convert.ToDateTime(time);
            int _second, _minute, _hour, _day, _year;
         
            _second = _time.Second - DateTime.Now.Second;
            _minute = _time.Minute - DateTime.Now.Minute;
            _hour = _time.Hour - DateTime.Now.Hour;
            _year = _time.Year - DateTime.Now.Year;

            if (_year == 0)
                _day = _time.DayOfYear - DateTime.Now.DayOfYear;
            else
                _day = _time.DayOfYear - DateTime.Now.DayOfYear + 366;

            if (_second < 0)
            {
                _minute--;
                _second += 60;
            }

            if (_minute < 0)
            {
                _hour--;
                _minute += 60;
            }

            if (_hour < 0)
            {
                _day--;
                _hour += 24;
            }

            if (_day < 0)
                return false;
            if (_year > 1)
                return false;
            return true;
        }

        public void setValue(string time)
        {
            DateTime t = Convert.ToDateTime(time);
            DatePicker.Value = t;
            TimePicker.Value = t;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("@gmail.com") == false && textBox1.Text.Contains("@gm.uit.edu.vn") == false)
                this.btnOK.Enabled = false;
            else
                this.btnOK.Enabled = true;


        }

        public void setEmail(string email)
        {
            this.textBox1.Text = email;
        }
    }
}
