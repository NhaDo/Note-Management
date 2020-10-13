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

        private void NavigationOption_Load(object sender, EventArgs e)
        {

        }
        
        private void opTitle_Click(object sender, EventArgs e)
        {
            Form1.getInstance().setWindow(opTitle.Text);

        }

        private void opIcon_Click(object sender, EventArgs e)
        {
            Form1.getInstance().setWindow(opTitle.Text);

        }
    }
}
