﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMakingApp.ViewComponents;
using NoteMakingApp.Models;

namespace NoteMakingApp
{
    public partial class PinTDL : Form
    {
        int _flag = 0;
        int _flag2 = 0;
        static int _e = -1;
        int _STT = 0;
        int _isDelete = -1;
        int type = 0;
        static List<ItemTDLs> eitem { get; set; }
        static ItemTDLs save { get; set; }
        static List<ItemTDLs> newitem { get; set; }
        static List<ItemTDLs> deletedItem { get; set; }

        public PinTDL()
        {
            newitem = new List<ItemTDLs>();
            deletedItem = new List<ItemTDLs>();
            InitializeComponent();
        }



        public void setValue(List<ItemTDLs> item)
        {
            _flag = 0;
            eitem = new List<ItemTDLs>(item);
            _STT = eitem[eitem.Count - 1].STT;
            foreach (ItemTDLs t in eitem)
            {
                ItemTDL i = new ItemTDL();
                i.Name = _flag.ToString();
                i.setValue(t.Content, t.STT, t.check);
                _flag++;
                i.edit();
                this.flowLayoutPanel1.Controls.Add(i);

                i.checkbox.CheckedChanged += (s, e) =>
                {
                    save.check = i.checkbox.Checked;
                    eitem.RemoveAt(_e);
                    eitem.Insert(_e, save);
                    UpdateData();
                };

                i.checkbox.Enter += (s, e) =>
                {
                    type = 1;
                    _isDelete = 0;
                    //STT = Int32.Parse(i.checkbox.Name);
                    _e = Int32.Parse(i.Name);
                    //Console.WriteLine(_e);
                    save = eitem.ElementAt(_e);
                    Console.WriteLine("_e " + _e);
                    UpdateData();
                };

                i.checkbox.Leave += (s, e) =>
                {
                    if (_isDelete == 0)
                    {
                        save.check = i.checkbox.Checked;
                        eitem.RemoveAt(_e);
                        eitem.Insert(_e, save);
                    }
                    UpdateData();
                };

                i.textBox1.Enter += (s, e) =>
                {
                    type = 1;
                    _isDelete = 0;
                    //STT = Int32.Parse(i.checkbox.Name);
                    _e = Int32.Parse(i.Name);
                    //Console.WriteLine(_e);
                    save = eitem.ElementAt(_e);
                    Console.WriteLine("_e " + _e);
                    UpdateData();
                };

                i.textBox1.Leave += (s, e) =>
                {
                    if (_isDelete == 0)
                    {
                        save.Content = i.textBox1.Text;
                        eitem.RemoveAt(_e);
                        eitem.Insert(_e, save);
                    }
                    UpdateData();

                };
            }
        }
        public void setName(string a)
        {
            this.Text = a;
        }

        public void setId(string a)
        {
            this.Name = a;
        }


        void UpdateData()
        {
            if (eitem.Count() == 0 && newitem.Count() == 0)
            {
                MessageBox.Show("Thêm list to do", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataHandle.getInstance().EditToDoList(this.Text, eitem);
                foreach (ItemTDLs i in newitem)
                    DataHandle.getInstance().CreateNewToDoList(this.Text, i.Content, i.STT, Convert.ToInt32(i.check));
                foreach (ItemTDLs i in deletedItem)
                    DataHandle.getInstance().DeleteItemInToDoList(this.Text, i.STT);
                DataHandle.getInstance().ShowNote();
            }
        }

        private void PinTDL_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            newitem.Add(new ItemTDLs()
            {
                STT = _STT + 1,
                check = false,
                Content = "Write Something"
            });

            ItemTDL i = new ItemTDL();
            i.Name = _flag2.ToString();
            i.setValue("Write Something", _STT + 1, false);
            i.edit();

            _flag2++;
            _STT++;

            this.flowLayoutPanel1.Controls.Add(i);

            i.checkbox.Enter += (s, ev) =>
            {
                type = 2;
                _isDelete = 0;
                _e = Int32.Parse(i.Name);
                //Console.WriteLine(_e);
                save = newitem.ElementAt(_e);
                //Console.WriteLine("_e " + _e);
                //Console.WriteLine("STT " + i.textBox1.Name);

            };

            i.checkbox.Leave += (s, ev) =>
            {
                if (_isDelete == 0)
                {
                    save.check = i.checkbox.Checked;
                    newitem.RemoveAt(_e);
                    newitem.Insert(_e, save);
                }

            };

            i.textBox1.Enter += (s, ev) =>
            {
                type = 2;
                _isDelete = 0;
                _e = Int32.Parse(i.Name);
                //Console.WriteLine(_e);
                save = newitem.ElementAt(_e);
                //Console.WriteLine("_e " + _e);
                //Console.WriteLine("STT " + i.textBox1.Name);

            };

            i.textBox1.Leave += (s, ev) =>
            {
                if (_isDelete == 0)
                {
                    save.Content = i.textBox1.Text;
                    newitem.RemoveAt(_e);
                    newitem.Insert(_e, save);
                }
            };
            UpdateData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            _isDelete = 1;
            if (_e < 0)
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (type == 1)
                {
                    deletedItem.Add(eitem.ElementAt(_e));
                    eitem.RemoveAt(_e);
                }
                else
                    newitem.RemoveAt(_e);
                this.flowLayoutPanel1.Controls.Clear();
                _flag = 0;
                _flag2 = 0;

                foreach (ItemTDLs t in eitem)
                {
                    ItemTDL i = new ItemTDL();
                    i.Name = _flag.ToString();
                    i.setValue(t.Content, t.STT, t.check);
                    _flag++;
                    i.edit();
                    this.flowLayoutPanel1.Controls.Add(i);

                    i.checkbox.Enter += (s, ev) =>
                    {
                        type = 1;
                        _isDelete = 0;
                        //STT = Int32.Parse(i.checkbox.Name);
                        _e = Int32.Parse(i.Name);
                        //Console.WriteLine(_e);
                        save = eitem.ElementAt(_e);
                        Console.WriteLine("_e " + _e);
                        Console.WriteLine("STT " + i.textBox1.Name);
                    };

                    i.checkbox.Leave += (s, ev) =>
                    {
                        if (_isDelete == 0)
                        {
                            save.check = i.checkbox.Checked;
                            eitem.RemoveAt(_e);
                            eitem.Insert(_e, save);
                        }

                    };

                    i.textBox1.Enter += (s, ev) =>
                    {
                        type = 1;
                        _isDelete = 0;
                        //STT = Int32.Parse(i.checkbox.Name);
                        _e = Int32.Parse(i.Name);
                        //Console.WriteLine(_e);
                        save = eitem.ElementAt(_e);
                        Console.WriteLine("_e " + _e);
                        Console.WriteLine("STT " + i.textBox1.Name);

                    };

                    i.textBox1.Leave += (s, ev) =>
                    {
                        if (_isDelete == 0)
                        {
                            save.Content = i.textBox1.Text;
                            eitem.RemoveAt(_e);
                            eitem.Insert(_e, save);
                        }
                    };
                }

                foreach (ItemTDLs t in newitem)
                {
                    ItemTDL i = new ItemTDL();
                    i.Name = _flag2.ToString();
                    i.setValue(t.Content, t.STT, t.check);
                    _flag2++;
                    i.edit();
                    this.flowLayoutPanel1.Controls.Add(i);

                    i.checkbox.Enter += (s, ev) =>
                    {
                        type = 2;
                        _isDelete = 0;
                        _e = Int32.Parse(i.Name);
                        //Console.WriteLine(_e);
                        save = newitem.ElementAt(_e);
                        Console.WriteLine("_e " + _e);
                        Console.WriteLine("STT " + i.textBox1.Name);

                    };

                    i.checkbox.Leave += (s, ev) =>
                    {
                        if (_isDelete == 0)
                        {
                            save.check = i.checkbox.Checked;
                            newitem.RemoveAt(_e);
                            newitem.Insert(_e, save);
                        }

                    };

                    i.textBox1.Enter += (s, ev) =>
                    {
                        type = 2;
                        _isDelete = 0;
                        _e = Int32.Parse(i.Name);
                        //Console.WriteLine(_e);
                        save = newitem.ElementAt(_e);
                        Console.WriteLine("_e " + _e);
                        Console.WriteLine("STT " + i.textBox1.Name);

                    };

                    i.textBox1.Leave += (s, ev) =>
                    {
                        if (_isDelete == 0)
                        {
                            save.Content = i.textBox1.Text;
                            newitem.RemoveAt(_e);
                            newitem.Insert(_e, save);
                        }
                    };
                }
            }
            UpdateData();

        }

        private void openHome_Click(object sender, EventArgs e)
        {
            Form1.getInstance().Show();
        }

        private void PinTDL_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}

