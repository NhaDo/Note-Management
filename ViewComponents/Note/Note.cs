using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using NoteMakingApp.Models;

namespace NoteMakingApp.ViewComponents
{
    public partial class _Note : UserControl
    {
        int _isClicked = 0;
        //string _Tittle, _Content;



        // for Pin
        PinForm PinnedForm;
        bool isPinned = false;

        public _Note()
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
            chanceImage = chanceImage.Substring(0, chanceImage.LastIndexOf(@"\"));
            // get path to image note4.png
            this.pictureBox1.Image = Image.FromFile(chanceImage + @"\Resources\Note.png");
            
        }

        public void chanceImage()
        {
            
            // get .exe path
            string chanceImage = Application.StartupPath;
            // get path from project folder (-bin, -debug)
            chanceImage=chanceImage.Substring(0,chanceImage.LastIndexOf(@"\"));
            chanceImage = chanceImage.Substring(0, chanceImage.LastIndexOf(@"\"));
            chanceImage = chanceImage.Substring(0, chanceImage.LastIndexOf(@"\"));
            // get path to image note3.png
            this.pictureBox1.Image = Image.FromFile(chanceImage + @"\Resources\Note_Hover.png");
            
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

        public bool isClicked=false; // if this note is clicked from main domain, return true

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Form1.type = 1;
            Console.WriteLine(_Flag);
            isClicked = !(isClicked);

        }

        private void lbContent_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Form1.type = 1;
            Console.WriteLine(_Flag);
            isClicked = !(isClicked);

        }

        private void lbTittle_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Form1.type = 1;
            Console.WriteLine(_Flag);
            isClicked = !(isClicked);

        }


        private void Note_MouseClick(object sender, MouseEventArgs e)
        {
            MainDomain.currentInstance.setFlags(getId());
            int _Flag = MainDomain.currentInstance.getFlags();
            Form1.type = 1;
            Console.WriteLine(_Flag);
            isClicked = !(isClicked);

        }

        private void Note_MouseHover(object sender, EventArgs e)
        {
            this.chanceImage();
        }

        private void Note_MouseLeave(object sender, EventArgs e)
        {
            if (isClicked == false)
                this.defaultImage();
        }

        private void IbTitle_MouseHover(object sender, EventArgs e)
        {
            this.chanceImage();
        }



        private void IbContent_MouseHover(object sender, EventArgs e)
        {
            this.chanceImage();
        }



        private void picture_MouseHover(object sender, EventArgs e)
        {
            this.chanceImage();
        }

        private void _Note_Load(object sender, EventArgs e)
        {

        }

        private void picture_MouseLeave(object sender, EventArgs e)
        {
            if (isClicked==false)
                this.defaultImage();

        }

        private void DoubleClick_PinNote(object sender, EventArgs e)
        {
            if (isPinned == false)
            {
                // new form
                PinnedForm = new PinForm();
                PinnedForm.MdiParent = null;

                // set form content
                PinnedForm.setContent(this.lbContent.Text);
                PinnedForm.setName(Int32.Parse(this.Name));
                PinnedForm.setTittle(this.lbTittle.Text);

                // show form
                PinnedForm.Show();
                PinnedForm.Size = new System.Drawing.Size(250, 180);


                //isPinned = true;
            }
        }


    }
}
