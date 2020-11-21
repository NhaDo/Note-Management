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
        public int fun;
        public bool clicked = false;
        public CustomButton()
        {
            InitializeComponent();
            this.button.Text = "";
            this.button.FlatAppearance.BorderSize = 0;
            this.detail.BackColor = Color.Yellow;
            this.detail.Visible = false;
            this.detail.BorderStyle = BorderStyle.FixedSingle;
            this.button.ImageList = buttonImage;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button.Cursor = Cursors.Hand;
            this.button.ImageIndex += 1;

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.detail.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.detail.Visible = false;
            this.button.Cursor = Cursors.Default;
            this.button.ImageIndex -= 1;
        }

        public void getText(string tex)
        {
            this.detail.Text = tex;
        }


        public void setImage(int index)
        {
            this.button.ImageIndex = index;
        }

        public void setFunction(int index)
        {
            this.fun = index;
        }

        public void button_Click(object sender, EventArgs e)
        {
            switch (fun)
            {
                case 1:
                    Form1.getInstance().NewNote();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }


        }
    }
}
