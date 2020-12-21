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
    public partial class Reminder : UserControl
    {
        int _flag = 0;
        
        public Reminder()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _flag = 1;
            this.Timer.Enabled = false;
            this.checkBox1.Checked = false;
            MessageBox.Show("haha");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (_flag == 0)
                this.Timer.Enabled = !this.Timer.Enabled;
            _flag = 0;
        }

        public int chanceTime(DateTime t)
        {
            int i = 0;
            i = ((t.Hour - DateTime.Now.Hour) * 3600 + (t.Minute - DateTime.Now.Minute)*60)*1000;
            if ((t.Day - DateTime.Now.Day) < 0)
                i = 0;
            
            if (i <= 0)
            {
                this.checkBox1.Checked = false;
                this.checkBox1.Enabled = false;
                //MessageBox.Show("Reminder " + this.lbTittle.Text + " đã quá thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 100;
            }
            return i;
        }

        public void setValue(string id,string Tittle,string Content,DateTime Time,int Check)
        {
            int _hour = Time.Hour;
            int _minute = Time.Minute;
            this.Name = id;
            this.lbTittle.Text = Tittle;
            this.lbContent.Text =   Content;
            this.checkBox1.Checked = Convert.ToBoolean(Check);
            this.lbTime.Text = Time.Hour + ":" + Time.Minute;
            this.Timer.Interval = chanceTime(Time);
           
        }

        private void lbTittle_Click(object sender, EventArgs e)
        {
            Form1.type = 3;
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Console.WriteLine(MainDomain.currentInstance.getFlags());
        }

        private void lbContent_Click(object sender, EventArgs e)
        {
            Form1.type = 3;
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Console.WriteLine(MainDomain.currentInstance.getFlags());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.type = 3;
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Console.WriteLine(MainDomain.currentInstance.getFlags());
        }

        private void Reminder_MouseClick(object sender, MouseEventArgs e)
        {
            Form1.type = 3;
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Console.WriteLine(MainDomain.currentInstance.getFlags());
        }
    }
}
