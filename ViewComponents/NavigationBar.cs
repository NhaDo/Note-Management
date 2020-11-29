using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using System.Runtime.CompilerServices;

namespace NoteMakingApp.ViewComponents
{
    public partial class NavigationBar : UserControl
    {
        public static NavigationBar instance;
        public static string recentOption;
        public static NavigationBar getInstance()
        {
            if (instance == null)
            {
                instance = new NavigationBar();
            }
           
            return instance;
        }
        public NavigationBar()
        {
            InitializeComponent();
        }

        public NavigationBar(List<String> titles, List<String> imageFiles)
        {
            addNavOptions(titles, imageFiles);
            InitializeComponent();
            if (navOptions.Count() != 0)
            {
                recentOption = titles.First();
            }


        }



        public void addNavOptions(List<String> titles, List<String> imageFiles)
        {
            foreach (var tt in titles)
            {
                addNavOption(tt, imageFiles[titles.IndexOf(tt)]);
            }
        }
        private void addNavOption(string tt, string img)
        {
            NavigationOption option = new NavigationOption(tt, img);
            option.Location = new System.Drawing.Point(0, (option.Size.Height+18) * navOptions.Count()+150);
            option.Click += new System.EventHandler(this.option_click);
            option.initOption();
            navOptions.Add(option);
            this.Controls.Add(navOptions[navOptions.Count - 1]);
            this.PerformLayout();
        }
        private void option_click(object sender, EventArgs e)
        {   
            foreach (NavigationOption item in navOptions)
            {
                item.opTitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 130);
                item.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
                item.opIcon.BackColor = System.Drawing.Color.FromArgb(51, 51, 51);
            }
            
            NavigationOption option = sender as NavigationOption;
            recentOption = option.opTitle.Text;
            option.opTitle.ForeColor = System.Drawing.Color.FromArgb(206, 105, 35);
            option.BackColor = System.Drawing.Color.FromArgb(110, 110, 110);
            option.opIcon.BackColor= System.Drawing.Color.FromArgb(110, 110, 110); 
            option.Isclicked = true;
            Form1.getInstance().setWindow(recentOption);
        }

        private void avt_MouseHover(object sender, EventArgs e)
        {
            this.bEdit.Visible = true;
        }

        private void bEdit_MosueLeave(object sender, EventArgs e)
        {
            this.bEdit.Visible = false;
        }

        private void navBar_MouseHover(object sender, EventArgs e)
        {
            this.bEdit.Visible = false;
        }

        private void username_paint(object sender, PaintEventArgs e)
        {
            string measureString = this.username.Text;
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(measureString, this.username.Font);
            this.username.Location = new System.Drawing.Point(this.Width / 2 - (int)stringSize.Width/2, 100);
            this.accountpic.Location = new System.Drawing.Point(username.Location.X-20, username.Location.Y);
        }
    }
}
