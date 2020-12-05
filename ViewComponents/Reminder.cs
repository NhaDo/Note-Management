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
        public Reminder()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Timer.Enabled = false;
            MessageBox.Show("haha");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Timer.Enabled = !this.Timer.Enabled;
            Console.WriteLine(this.Timer.Enabled);
        }

        public void setValue(string id,string Tittle,string Content,int Time,int Check)
        {
            this.Name = id;
            this.lbTittle.Text = Tittle;
            this.lbContent.Text =   Content;
            this.Timer.Interval = Time*1000;
            this.checkBox1.Checked = Convert.ToBoolean(Check);
        }

        
    }
}
