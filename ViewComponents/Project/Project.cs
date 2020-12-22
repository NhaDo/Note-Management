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
            //a = 0;b = 0;
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
            MainDomain.currentInstance.showListProject();
            this.Dispose();
        }

        public void setComplete(string a)
        {
            this.lbComplete.Text = "Complete: " + a + "%";
        }
    }
}
