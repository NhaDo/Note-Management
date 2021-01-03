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
        // for Pin
        PinTDL PinnedForm;
        bool isPinned = false;
        List<ItemTDLs> Items;

        public ToDoList()
        {
            InitializeComponent();
            
        }
        public void defaultImage()
        {

            this.pictureBox1.Image = global::NoteMakingApp.Properties.Resources.ToDoList1;

        }

        public void chanceImage()
        {
            this.pictureBox1.Image = global::NoteMakingApp.Properties.Resources.ToDoList_Hover;


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
            this.Items = a;
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


        private void DoubeClick_PinTDL(object sender, EventArgs e)
        {
            if (isPinned == false)
            {
                // new form
                PinnedForm = new PinTDL();

                // set form content
                PinnedForm.setId(this.Name);
                PinnedForm.setName(this.lbName.Text);
                //PinnedForm.addItem(this.Items);
                PinnedForm.setValue(this.Items);

                // show form
                PinnedForm.Show();
                PinnedForm.Size = new System.Drawing.Size(230, 250);
                isPinned = true;
            }
        }
    }
}
