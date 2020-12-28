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

namespace NoteMakingApp.ViewComponents.Project
{
    public partial class ListProject : UserControl
    {
        int i = 1;
        public static int user_id;
        
        public ListProject()
        {
            InitializeComponent();
            this.flowLayoutPanel1.Controls.Clear();
            DataHandle.getInstance().GetDataFromProject();
            AddProject(0, "New Project");
            foreach (Projects t in DataHandle.prjs)
                if (t.user_id == user_id)
                    AddProject(t.id, t.Tittle);
             

        }

        public void AddProject(int a, string b)
        {
            Button prj = new Button();
            prj.Name = a.ToString();
            prj.Text = b;
            prj.Size = new System.Drawing.Size(100, 25);
            if (i == 1)
            {
                prj.BackColor = Color.Aqua;
                prj.Click += (s, e) =>
                {
                    MainDomain.currentInstance.enableButton();
                    Form1.type = 4;
                    this.Dispose();
                    Form1.getInstance().NewProject();
                };
            }
            else
            {
                prj.Click += (s, e) =>
                {
                    double x = 0;
                    double y = 0;
                    string z;
                    Form1.type = 4;
                    MainDomain.currentInstance.setFlags(Int32.Parse(prj.Name));
                    Console.WriteLine(MainDomain.currentInstance.getFlags());
                    MainDomain.currentInstance.enableButton();
                    this.Dispose();

                    Projects p =  DataHandle.getInstance().GetDataProject();
                    foreach (ItemProjects i in p.item)
                    {
                        if (i.check == true)
                            x++;
                        y++;
                    }
                    x = ((x / y) * 100);
                    if (x.ToString().Length > 5)
                    {
                        z = x.ToString().Substring(0, 5);
                        
                    }
                    else
                    {
                        z = x.ToString();
                        
                    }

                    
                    Form1.getInstance().ShowProject(p.Tittle,p.item,z,p.deadline);


                    
                };
            }
            i++;
            this.flowLayoutPanel1.Controls.Add(prj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MainDomain.currentInstance.enableButton();
        }

        
    }
}
