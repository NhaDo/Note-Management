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
                    double x = 0;
                    double y = 0;
                    string z;
                    //Form1.type = 2;
                    MainDomain.currentInstance.setFlags(Int32.Parse(prj.Name));
                    Console.WriteLine(MainDomain.currentInstance.getFlags());

                    MainDomain.currentInstance.CloseProject();
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
                        Console.WriteLine("haha");
                    }
                    else
                    {
                        z = x.ToString();
                        Console.WriteLine("hohoh");
                    }

                    Console.WriteLine(z.Length);
                    Form1.getInstance().ShowProject(tdl.Tittle,tdl.item,z);


                    /*double i = (Convert.ToDouble(2.54) / 10) * 100;
                    Console.WriteLine(i);
                    if (i.ToString().Length > 5)
                        label1.Text = i.ToString().Substring(0, 5);
                    else
                        label1.Text = i.ToString();
                    Console.WriteLine(label1.Text);*/
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
