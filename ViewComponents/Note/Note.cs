using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NoteMakingApp.ViewComponents
{
    public partial class Note : UserControl
    {
        int _isClicked = 0;
        //string _Tittle, _Content;
        

        public Note()
        {
            InitializeComponent();
            defaultImage();
            
        }

        public void defaultImage()
        {
            // get .exe path
            string chanceImage = Application.StartupPath;
            // get path from project folder (-bin, -debug)
            chanceImage = chanceImage.Substring(0, chanceImage.LastIndexOf(@"\"));
            chanceImage = chanceImage.Substring(0, chanceImage.LastIndexOf(@"\"));
            // get path to image note4.png
            this.pictureBox1.Image = Image.FromFile(chanceImage + @"\Resources\Note4.png");
        }

        public void chanceImage()
        {
            // get .exe path
            string chanceImage = Application.StartupPath;
            // get path from project folder (-bin, -debug)
            chanceImage=chanceImage.Substring(0,chanceImage.LastIndexOf(@"\"));
            chanceImage = chanceImage.Substring(0, chanceImage.LastIndexOf(@"\"));
            // get path to image note3.png
            this.pictureBox1.Image = Image.FromFile(chanceImage + @"\Resources\Note3.png");
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

        public bool isClicked=false; // if this note is clicked from main domain, return 1

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Console.WriteLine(_Flag);
            

        }

        private void lbContent_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Console.WriteLine(_Flag);
            
        }

        private void lbTittle_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Console.WriteLine(_Flag);
            
        }


        private void Note_MouseClick(object sender, MouseEventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Console.WriteLine(_Flag);
            
        }

        
    }
}
