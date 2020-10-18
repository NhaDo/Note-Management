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
            //option.Size = new System.Drawing.Size(163, 90);
            option.Location = new System.Drawing.Point(0, (option.Size.Height+18) * navOptions.Count()+250);
            option.Click += new System.EventHandler(this.option_click);
            option.initOption();
            navOptions.Add(option);
            this.Controls.Add(navOptions[navOptions.Count - 1]);
            this.PerformLayout();
        }
        private void option_click(object sender, EventArgs e)
        {
            if (OneIsClicked == false)
            {
                NavigationOption option = sender as NavigationOption;
                recent_selected = option; // here
                recentOption = option.opTitle.Text;
                Form1.getInstance().setWindow(recentOption);
                OneIsClicked = true;
            }
            else
            {
                NavigationOption option = sender as NavigationOption;
                recent_selected.defautsettings(); // here
                recent_selected = option; // here
                recentOption = option.opTitle.Text;
                Form1.getInstance().setWindow(recentOption);
                OneIsClicked = true;
            }
        }
        public bool OneIsClicked = false;
        public NavigationOption recent_selected; // here
    }
}
