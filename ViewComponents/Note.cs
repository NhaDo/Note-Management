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
    public partial class Note : UserControl
    {
        int _isClicked = 0;
        string _Tittle, _Content;
        

        public Note()
        {
            InitializeComponent();
            defaultImage();
        }

        public void defaultImage()
        {
            //this.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\Note4.png");
        }

        public void chanceImage()
        {
            //this.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\Note3.png");
        }

        public void setTittle(string text)
        {
            this.lbTittle.Text = text;
        }

        public void setContent(string text)
        {
            this.lbContent.Text = text;
        }

        public void setName(int id)
        {
            this.Name = id.ToString();
        }




        public int getId()
        {
            _isClicked = Int32.Parse(this.Name);
            return _isClicked;
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Console.WriteLine(_Flag);
            chanceImage();

        }

        private void lbContent_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Console.WriteLine(_Flag);
            chanceImage();
        }

        private void lbTittle_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Console.WriteLine(_Flag);
            chanceImage();
        }

        private void Note_MouseClick(object sender, MouseEventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Console.WriteLine(_Flag);
            chanceImage();
        }

        
    }
}
