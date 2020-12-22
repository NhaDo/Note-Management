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
        }

        public void AddProject(int a, string b)
        {
            Button prj = new Button();
            prj.Name = a.ToString();
            prj.Text = b;
            prj.Size = new System.Drawing.Size(100, 25);
            if (i == 1)
            {
                prj.Click += (s, e) =>
                {
                    Form1.type = 4;
                    MainDomain.currentInstance.CloseProject();
                    Form1.getInstance().NewToDoList();

                };
            }
            else
            {
                prj.Click += (s, e) =>
                {
                    //Form1.type = 2;
                    MainDomain.currentInstance.setFlags(Int32.Parse(prj.Name));
                    Console.WriteLine(MainDomain.currentInstance.getFlags());

                    MainDomain.currentInstance.CloseProject();
                    ToDoLists tdl =  DataHandle.getInstance().GetDataToDoList();
                    Form1.getInstance().ShowProject(tdl.Tittle,tdl.item);
                };
            }
            i++;
            this.flowLayoutPanel1.Controls.Add(prj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainDomain.currentInstance.CloseProject();
        }

        public void ClearProject()
        {
            this.flowLayoutPanel1.Controls.Clear();
        }
    }
}
