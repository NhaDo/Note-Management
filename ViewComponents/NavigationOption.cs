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
    public partial class NavigationOption : UserControl
    {
        const string imageFolderPath = "";
        public NavigationOption()
        {
            InitializeComponent();
        }
        public NavigationOption(string title, string imageFile)
        {
            InitializeComponent();
            opTitle.Text = title;
            // opIcon.Image = Image.FromFile(imageFolderPath + imageFile);
        }

        public void defautsettings()
        {
            this.opTitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 130);
            this.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.opIcon.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
        }

        public void initOption()
        {
            this.MouseHover += new System.EventHandler(this.NavigationOption_MouseHover);
            this.opTitle.MouseHover += new System.EventHandler(this.Optitle_MouseHover);
            this.opIcon.MouseHover += new System.EventHandler(this.OpIcon_MouseHover);
            this.MouseLeave += new System.EventHandler(this.NavigationOption_MouseLeave);
            this.opTitle.MouseLeave += new System.EventHandler(this.Optitle_MouseLeave);
            this.opIcon.MouseLeave += new System.EventHandler(this.OpIcon_MouseLeave);
            this.Click += new System.EventHandler(this.NavigationOption_Click);
            this.opTitle.Click += new System.EventHandler(this.opTitle_Click);
            this.opIcon.Click += new System.EventHandler(this.opIcon_Click);
        }
        private void NavigationOption_MouseHover(object sender, EventArgs e)
        {
            this.opTitle.ForeColor = System.Drawing.Color.FromArgb(206, 105, 35);
            this.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.opIcon.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
        }
        private void Optitle_MouseHover(object sender, EventArgs e)
        {
            this.opTitle.ForeColor = System.Drawing.Color.FromArgb(206, 105, 35);
            this.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.opIcon.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
        }
        private void OpIcon_MouseHover(object sender, EventArgs e)
        {
            this.opTitle.ForeColor = System.Drawing.Color.FromArgb(206, 105, 35);
            this.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.opIcon.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
        }

        private void NavigationOption_MouseLeave(object sender, EventArgs e)
        {
            if (!this.Isclicked)
            {
                this.opTitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 130);
                this.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
                this.opIcon.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            }
        }

        private void Optitle_MouseLeave(object sender, EventArgs e)
        {
            if (!this.Isclicked)
            {
                this.NavigationOption_MouseLeave(sender, e);
            }
        }
        private void OpIcon_MouseLeave(object sender, EventArgs e)
        {
            if (!this.Isclicked)
            {
                this.NavigationOption_MouseLeave(sender, e);
            }
        }


        private void NavigationOption_Load(object sender, EventArgs e)
        {

        }        
        private void opTitle_Click(object sender, EventArgs e)
        {
            Form1.getInstance().setWindow(opTitle.Text);
            this.opTitle.ForeColor = System.Drawing.Color.FromArgb(206, 105, 35);
            this.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.Isclicked = true;
        }
        private void NavigationOption_Click(object sender, EventArgs e)
        {
            Form1.getInstance().setWindow(opTitle.Text);
            this.opTitle.ForeColor = System.Drawing.Color.FromArgb(206, 105, 35);
            this.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.Isclicked = true;
        }

        private void opIcon_Click(object sender, EventArgs e)
        {
            Form1.getInstance().setWindow(opTitle.Text);
            this.opTitle.ForeColor = System.Drawing.Color.FromArgb(206, 105, 35);
            this.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
            this.Isclicked = true;

        }
        public bool Isclicked=false;
    }
}
