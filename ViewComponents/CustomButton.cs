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
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
            this.button.Text = "";
            this.button.FlatAppearance.BorderSize = 0;
            this.detail.BackColor = Color.Yellow;
            this.detail.Visible = false;
            this.detail.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button.Cursor = Cursors.Hand;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.detail.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.detail.Visible = false;
            this.button.Cursor = Cursors.Default;
        }

        public void getText(string tex)
        {
            this.detail.Text = tex;
        }

        public void getImage(string path1)
        {
            this.button.Image = Image.FromFile(path1);
        }
    }
}
