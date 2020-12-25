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

namespace NoteMakingApp.ViewComponents.Note
{

    public partial class EditToDoList : UserControl
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
        public EditToDoList()
        {
            newitem = new List<ItemTDLs>();
            InitializeComponent();
        }

        public void setValue(string name, List<ItemTDLs> item)
        {
            _flag = 0;
            eitem = new List<ItemTDLs>(item);
            _STT = eitem[eitem.Count - 1].STT;
            this.txtTittle.Text = name;
            foreach (ItemTDLs t in eitem)
            {
                ItemTDL i = new ItemTDL();
                i.Name = _flag.ToString();
                i.setValue(t.Content, t.STT, t.check);
                _flag++;
                i.edit();
                this.flowLayoutPanel1.Controls.Add(i);

                i.checkbox.Enter += (s, e) =>
                {
                    type = 1;
                    _isDelete = 0;
                    //STT = Int32.Parse(i.checkbox.Name);
                    _e = Int32.Parse(i.Name);
                    //Console.WriteLine(_e);
                    save = eitem.ElementAt(_e);
                    Console.WriteLine("_e " + _e);
                    
                };

                i.checkbox.Leave += (s, e) =>
                {
                    if (_isDelete == 0)
                    {
                        save.check = i.checkbox.Checked;
                        eitem.RemoveAt(_e);
                        eitem.Insert(_e, save);
                    }

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
                    

                };

                i.textBox1.Leave += (s, e) =>
                {
                    if (_isDelete == 0)
                    {
                        save.Content = i.textBox1.Text;
                        eitem.RemoveAt(_e);
                        eitem.Insert(_e, save);
                    }
                };
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTittle.Text == "")
                MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (DataHandle.getInstance().checkTittleToDoList(txtTittle.Text) == false)
                    MessageBox.Show("Tittle đã tồn tại!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataHandle.getInstance().EditToDoList(txtTittle.Text, eitem);
                    foreach (ItemTDLs i in newitem)
                        DataHandle.getInstance().CreateNewToDoList(txtTittle.Text, i.Content, i.STT, Convert.ToInt32(i.check));
                    DataHandle.getInstance().ShowNote();
                    this.Dispose();
                }
        }

        private void pictureBox2_Click(object sender, EventArgs g)
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

            i.checkbox.Enter += (s, e) =>
            {
                type = 2;
                _isDelete = 0;
                _e = Int32.Parse(i.Name);
                //Console.WriteLine(_e);
                save = newitem.ElementAt(_e);
                Console.WriteLine("_e " + _e);
                Console.WriteLine("STT " + i.textBox1.Name);

            };

            i.checkbox.Leave += (s, e) =>
            {
                if (_isDelete == 0)
                {
                    save.check = i.checkbox.Checked;
                    newitem.RemoveAt(_e);
                    newitem.Insert(_e, save);
                }

            };

            i.textBox1.Enter += (s, e) =>
            {
                type = 2;
                _isDelete = 0;
                _e = Int32.Parse(i.Name);
                //Console.WriteLine(_e);
                save = newitem.ElementAt(_e);
                Console.WriteLine("_e " + _e);
                Console.WriteLine("STT " + i.textBox1.Name);

            };

            i.textBox1.Leave += (s, e) =>
            {
                if (_isDelete == 0)
                {
                    save.Content = i.textBox1.Text;
                    newitem.RemoveAt(_e);
                    newitem.Insert(_e, save);
                }
            };
        }


        private void pictureBox1_Click(object sender, EventArgs g)
        {
            _isDelete = 1;
            this.flowLayoutPanel1.Controls.Clear();

            if (_e < 0)
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (type == 1)
                    eitem.RemoveAt(_e);
                else
                    newitem.RemoveAt(_e);
                this.flowLayoutPanel1.Controls.Clear();
                _flag = 0;

                foreach (ItemTDLs t in eitem)
                {
                    ItemTDL i = new ItemTDL();
                    i.Name = _flag.ToString();
                    i.setValue(t.Content, t.STT, t.check);
                    _flag++;
                    i.edit();
                    this.flowLayoutPanel1.Controls.Add(i);

                    i.checkbox.Enter += (s, e) =>
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

                    i.checkbox.Leave += (s, e) =>
                    {
                        if (_isDelete == 0)
                        {
                            save.check = i.checkbox.Checked;
                            eitem.RemoveAt(_e);
                            eitem.Insert(_e, save);
                        }

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
                        Console.WriteLine("STT " + i.textBox1.Name);

                    };

                    i.textBox1.Leave += (s, e) =>
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
                    i.Name = _flag.ToString();
                    i.setValue(t.Content, t.STT, t.check);
                    _flag++;
                    i.edit();
                    this.flowLayoutPanel1.Controls.Add(i);

                    i.checkbox.Enter += (s, e) =>
                    {
                        type = 2;
                        _isDelete = 0;
                        _e = Int32.Parse(i.Name);
                        //Console.WriteLine(_e);
                        save = newitem.ElementAt(_e);
                        Console.WriteLine("_e " + _e);
                        Console.WriteLine("STT " + i.textBox1.Name);

                    };

                    i.checkbox.Leave += (s, e) =>
                    {
                        if (_isDelete == 0)
                        {
                            save.check = i.checkbox.Checked;
                            newitem.RemoveAt(_e);
                            newitem.Insert(_e, save);
                        }

                    };

                    i.textBox1.Enter += (s, e) =>
                    {
                        type = 2;
                        _isDelete = 0;
                        _e = Int32.Parse(i.Name);
                        //Console.WriteLine(_e);
                        save = newitem.ElementAt(_e);
                        Console.WriteLine("_e " + _e);
                        Console.WriteLine("STT " + i.textBox1.Name);

                    };

                    i.textBox1.Leave += (s, e) =>
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
        }
    }
}
