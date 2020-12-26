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

        List<ItemProjects> item;
        ItemProjects save;
        List<ItemProjects> newitem;
        List<ItemProjects> deletedItem;
        int _flag = 0;
        int _flag2 = 0;
        static int _e = -1;
        int _STT = 0;
        int _isDelete = -1;
        int type = 0;

        public Project()
        {
            save = new ItemProjects();
            deletedItem = new List<ItemProjects>();
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

        public void setValue(string nameProject, List<ItemProjects> items)
        {
            item = new List<ItemProjects>(items);

            this.lbProjectName.Text = nameProject;
            this.txtTittle.Text = nameProject;
            foreach (ItemProjects t in items)
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

            DataHandle.getInstance().DeleteProject();

            this.Dispose();
        }

        public void setComplete(string a)
        {
            this.lbComplete.Text = "Complete: " + a + "%";
        }

        private void btnEdit_Click(object sender, EventArgs g)
        {
            _STT = item[item.Count - 1].STT;
            newitem = new List<ItemProjects>();
            _flag = 0;
            _flag2 = 0;

            this.btnEdit.Enabled = false;
            this.lbProjectName.Visible = false;
            this.txtTittle.Visible = true;
            this.lbComplete.Visible = false;
            btnOK.Visible = true;
            btnDel.Visible = true;
            btnCancel.Visible = true;
            btnAdd.Visible = true;
            this.panel1.Visible = false;

            this.flowLayoutPanel1.Controls.Clear();

            foreach (ItemProjects t in item)
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
                    _e = Int32.Parse(i.Name);
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

                    _e = Int32.Parse(i.Name);

                    Console.WriteLine("_e " + _e);
                    save = item.ElementAt(_e);


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
            this.btnEdit.Enabled = true;
            this.lbProjectName.Visible = true;
            this.txtTittle.Visible = false;
            this.lbComplete.Visible = true;
            this.btnAdd.Visible = false;
            btnOK.Visible = false;
            btnDel.Visible = false;
            btnCancel.Visible = false;
            this.flowLayoutPanel1.Controls.Clear();
            foreach (ItemProjects t in item)
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
                DataHandle.getInstance().EditProject(txtTittle.Text, item);
                foreach (ItemProjects i in newitem)
                    DataHandle.getInstance().CreateNewProject(txtTittle.Text, i.Content, i.STT, Convert.ToInt32(i.check));
                foreach (ItemProjects i in deletedItem)
                    DataHandle.getInstance().DeleteItemInProject(txtTittle.Text, i.STT);

                double x = 0;
                double y = 0;
                string z;
                Form1.type = 4;

                this.Dispose();

                Projects p = DataHandle.getInstance().GetDataProject();

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


                Form1.getInstance().ShowProject(p.Tittle, p.item, z);


            }
        }

        private void btnAdd_Click(object sender, EventArgs g)
        {
            newitem.Add(new ItemProjects()
            {
                STT = _STT + 1,
                check = false,
                Content = "Write Something"
            });

            EditItem i = new EditItem();
            i.Name = _flag2.ToString();
            i.setValue(_STT + 1, "Write Something", false);


            _flag2++;
            _STT++;

            this.flowLayoutPanel1.Controls.Add(i);

            i.checkBox.Enter += (s, e) =>
            {
                type = 2;
                _isDelete = 0;
                _e = Int32.Parse(i.Name);
                Console.WriteLine("_e " + _e);
                Console.WriteLine("STT " + i.textBox.Name);
                save = newitem.ElementAt(_e);
            };

            i.checkBox.Leave += (s, e) =>
            {
                if (_isDelete == 0)
                {
                    save.check = i.checkBox.Checked;
                    newitem.RemoveAt(_e);
                    newitem.Insert(_e, save);
                }

            };

            i.textBox.Enter += (s, e) =>
            {
                type = 2;
                _isDelete = 0;
                _e = Int32.Parse(i.Name);
                Console.WriteLine("_e " + _e);
                Console.WriteLine("STT " + i.textBox.Name);
                save = newitem.ElementAt(_e);


            };

            i.textBox.Leave += (s, e) =>
            {
                if (_isDelete == 0)
                {
                    save.Content = i.textBox.Text;
                    newitem.RemoveAt(_e);
                    newitem.Insert(_e, save);
                }
            };
        }

        private void addNewEditItem()
        {
            if (type == 1)
            {
                deletedItem.Add(item.ElementAt(_e));
                item.RemoveAt(_e);
            }
            else
                newitem.RemoveAt(_e);
            this.flowLayoutPanel1.Controls.Clear();
            _flag = 0;

            foreach (ItemProjects t in item)
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
                    _e = Int32.Parse(i.Name);
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

                    _e = Int32.Parse(i.Name);

                    Console.WriteLine("_e " + _e);
                    save = item.ElementAt(_e);


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

            foreach (ItemProjects t in newitem)
            {
                EditItem i = new EditItem();
                i.Name = _flag.ToString();
                i.setValue(t.STT, t.Content, t.check);
                _flag++;

                this.flowLayoutPanel1.Controls.Add(i);

                i.checkBox.Enter += (s, e) =>
                {
                    type = 2;
                    _isDelete = 0;
                    _e = Int32.Parse(i.Name);
                    Console.WriteLine("_e " + _e);
                    Console.WriteLine("STT " + i.textBox.Name);
                    save = newitem.ElementAt(_e);
                };

                i.checkBox.Leave += (s, e) =>
                {
                    if (_isDelete == 0)
                    {
                        save.check = i.checkBox.Checked;
                        newitem.RemoveAt(_e);
                        newitem.Insert(_e, save);
                    }

                };

                i.textBox.Enter += (s, e) =>
                {
                    type = 2;
                    _isDelete = 0;
                    _e = Int32.Parse(i.Name);
                    Console.WriteLine("_e " + _e);
                    Console.WriteLine("STT " + i.textBox.Name);
                    save = newitem.ElementAt(_e);


                };

                i.textBox.Leave += (s, e) =>
                {
                    if (_isDelete == 0)
                    {
                        save.Content = i.textBox.Text;
                        newitem.RemoveAt(_e);
                        newitem.Insert(_e, save);
                    }
                };

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _isDelete = 1;
            if (_e < 0)
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                addNewEditItem();
        }
    }
}
