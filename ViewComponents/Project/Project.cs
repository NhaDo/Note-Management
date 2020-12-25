using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMakingApp.ViewComponents.Project;
using NoteMakingApp.Models;

namespace NoteMakingApp.ViewComponents.Project
{
    public partial class Project : UserControl
    {
        //double a = 0, b = 0;
        List<ItemTDLs> save;
        public Project()
        {
            InitializeComponent();
        }


        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = !this.panel1.Visible;
        }

        private void lbComplete_Click(object sender, EventArgs e)
        {

        }

        private void Project_Load(object sender, EventArgs e)
        {

        }

        public void setValue(string nameProject, List<ItemTDLs> items)
        {
            save = new List<ItemTDLs>(items);
            this.lbProjectName.Text = nameProject;
            foreach (ItemTDLs t in items)
            {
                ItemProject i = new ItemProject();
                i.setValue(t.STT, t.Content, t.check);
                this.flowLayoutPanel1.Controls.Add(i);
                //if (t.check == true)
                    //a++;
                //b++;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DataHandle.getInstance().DeleteToDoList();
            
            this.Dispose();
        }

        public void setComplete(string a)
        {
            this.lbComplete.Text = "Complete: " + a + "%";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnOK.Visible = true;
            btnCancel.Visible = true;
            this.panel1.Visible = false;
            this.flowLayoutPanel1.Controls.Clear();
            foreach (ItemTDLs t in save)
            {
                EditItem et = new EditItem();
                et.setValue(t.STT, t.Content, t.check);
                this.flowLayoutPanel1.Controls.Add(et);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnOK.Visible = false;
            btnCancel.Visible = false;
            this.flowLayoutPanel1.Controls.Clear();
            foreach (ItemTDLs t in save)
            {
                ItemProject i = new ItemProject();
                i.setValue(t.STT, t.Content, t.check);
                this.flowLayoutPanel1.Controls.Add(i);
            }
        }
    }
}
