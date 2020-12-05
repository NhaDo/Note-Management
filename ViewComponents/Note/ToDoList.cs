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

        private void lbName_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Form1.type = 2;
            Console.WriteLine(MainDomain.currentInstance.getFlags());
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Form1.type = 2;
            Console.WriteLine(MainDomain.currentInstance.getFlags());
        }

        private void flPanel_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Form1.type = 2;
            Console.WriteLine(MainDomain.currentInstance.getFlags());
        }

        private void ToDoList_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.setFlags(Int32.Parse(this.Name));
            Form1.type = 2;
            Console.WriteLine(MainDomain.currentInstance.getFlags());
        }
    }
}
