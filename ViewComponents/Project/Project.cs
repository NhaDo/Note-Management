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
        
        List<ItemTDLs> item;
        ItemTDLs save;

        int _flag = 0;
        int _flag2 = 0;
        static int _e = -1;
        int _STT = 0;
        int _isDelete = -1;
        int type = 0;

        public Project()
        {
            save = new ItemTDLs();
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
            item = new List<ItemTDLs>(items);
            this.lbProjectName.Text = nameProject;
            this.txtTittle.Text = nameProject;
            foreach (ItemTDLs t in items)
            {
                ItemProject i = new ItemProject();
                i.setValue(t.STT, t.Content, t.check);
                this.flowLayoutPanel1.Controls.Add(i);
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

        private void btnEdit_Click(object sender, EventArgs g)
        {
            this.lbProjectName.Visible = false;
            this.txtTittle.Visible = true;
            _flag = 0;
            this.lbComplete.Visible = false;
            btnOK.Visible = true;
            btnCancel.Visible = true;
            this.panel1.Visible = false;
            this.flowLayoutPanel1.Controls.Clear();

            foreach (ItemTDLs t in item)
            {
                EditItem i = new EditItem();
                i.Name = _flag.ToString();
                
                i.setValue(t.STT, t.Content, t.check);

                _flag++;

                this.flowLayoutPanel1.Controls.Add(i);

                i.checkBox.Enter += (s, e) =>
                {
                    type = 1;
                    _isDelete = 0;
                    _e = Int32.Parse(i.Name) -1;
                    save = item.ElementAt(_e);
                    Console.WriteLine("_e " + _e);
                    
                };

                i.checkBox.Leave += (s, e) =>
                {
                    if (_isDelete == 0)
                    {
                        save.check = i.checkBox.Checked;
                        item.RemoveAt(_e);
                        item.Insert(_e, save);
                    }

                };

                i.textBox.Enter += (s, e) =>
                {
                    type = 1;
                    _isDelete = 0;
                    
                    _e = Int32.Parse(i.Name)-1;
                    
                    save = item.ElementAt(_e);
                    Console.WriteLine("_e " + _e);
                    

                };

                i.textBox.Leave += (s, e) =>
                {
                    if (_isDelete == 0)
                    {
                        save.Content = i.textBox.Text;
                        item.RemoveAt(_e);
                        item.Insert(_e, save);
                    }
                };
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.lbProjectName.Visible = true;
            this.txtTittle.Visible = false;
            this.lbComplete.Visible = true;
            btnOK.Visible = false;
            btnCancel.Visible = false;
            this.flowLayoutPanel1.Controls.Clear();
            foreach (ItemTDLs t in item)
            {
                ItemProject i = new ItemProject();
                i.setValue(t.STT, t.Content, t.check);
                this.flowLayoutPanel1.Controls.Add(i);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTittle.Text == "")
                MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataHandle.getInstance().EditToDoList(txtTittle.Text, item);
                //foreach (ItemTDLs i in newitem)
                    //DataHandle.getInstance().CreateNewToDoList(txtTittle.Text, i.Content, i.STT, Convert.ToInt32(i.check));
                DataHandle.getInstance().ShowNote();

                double x = 0;
                double y = 0;
                string z;
                Form1.type = 4;

                this.Dispose();

                ToDoLists tdl = DataHandle.getInstance().GetDataToDoList();
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


                Form1.getInstance().ShowProject(tdl.Tittle, tdl.item, z);

                
            }
        }
    }
}
