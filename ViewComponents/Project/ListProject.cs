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
        public static ListProject currentInstance { get; set; }
        public ListProject()
        {
            InitializeComponent();
            currentInstance = this;

            //DataHandle.tdls.Clear();
            ListProject.currentInstance.ClearProject();
            DataHandle.getInstance().GetDataFromTDL();
            AddProject(0, "New Project");
            foreach (ToDoLists t in DataHandle.tdls)
                if (t.project == 1)
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

                    this.Dispose();

                    ToDoLists tdl =  DataHandle.getInstance().GetDataToDoList();
                    foreach (ItemTDLs i in tdl.item)
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

                    
                    Form1.getInstance().ShowProject(tdl.Tittle,tdl.item,z);


                    
                };
            }
            i++;
            this.flowLayoutPanel1.Controls.Add(prj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ClearProject()
        {
            this.flowLayoutPanel1.Controls.Clear();
        }
    }
}
