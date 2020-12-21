using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMakingApp.Models;

namespace NoteMakingApp.ViewComponents
{
    public partial class ToDoList : UserControl
    {
        
        public ToDoList()
        {
            InitializeComponent();
            
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
            this.pictureBox1.Image = Image.FromFile(chanceImage + @"\Note-Management\Resources\ToDoList.png");

        }

        public void chanceImage()
        {

            // get .exe path
            string chanceImage = Application.StartupPath;
            // get path from project folder (-bin, -debug)
            chanceImage = chanceImage.Substring(0, chanceImage.LastIndexOf(@"\"));
            chanceImage = chanceImage.Substring(0, chanceImage.LastIndexOf(@"\"));
            chanceImage = chanceImage.Substring(0, chanceImage.LastIndexOf(@"\"));
            // get path to image note3.png
            this.pictureBox1.Image = Image.FromFile(chanceImage + @"\Note-Management\Resources\ToDoList_Hover.png");

        }

        public void setName(string a)
        {
            this.lbName.Text = a;
        }

        public void setId(string a)
        {
            this.Name = a;
        }

        public void addItem(List<ItemTDLs> a)
        {
            foreach(ItemTDLs t in a)
            {
                ItemTDL i = new ItemTDL();
                i.setValue(t.Content,t.STT,t.check);
                i.read();
                this.flPanel.Controls.Add(i);
                
            }
        }

        public bool isClicked = false;
        private void lbName_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Form1.type = 2;
            Console.WriteLine(MainDomain.currentInstance.getFlags());
            isClicked = !(isClicked);

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Form1.type = 2;
            Console.WriteLine(MainDomain.currentInstance.getFlags());
            isClicked = !(isClicked);

        }

        private void flPanel_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Form1.type = 2;
            Console.WriteLine(MainDomain.currentInstance.getFlags());
            isClicked = !(isClicked);

        }

        private void ToDoList_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Form1.type = 2;
            Console.WriteLine(MainDomain.currentInstance.getFlags());
            isClicked = !(isClicked);

        }

        private void ToDoList_MouseHover(object sender, EventArgs e)
        {
            this.chanceImage();
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            this.chanceImage();

        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (isClicked == false)
                this.defaultImage();
        }

        private void Title_MouseHover(object sender, EventArgs e)
        {
            this.chanceImage();

        }

        private void Content_MouseHover(object sender, EventArgs e)
        {
            this.chanceImage();

        }
    }
}
