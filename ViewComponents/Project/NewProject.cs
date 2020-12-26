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
    public partial class NewProject : UserControl
    {

        static List<string> txtbox { get; set; }
        public static int User_ID;
        static int _e = -1;
        int i = 0;
        int _flag = 0;
        int save;

        public NewProject()
        {
            txtbox = new List<string>();

            InitializeComponent();
            ButtonAdd();
        }



        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = !this.panel1.Visible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs g)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTittle.Text == "")
                MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                int p = 1;
                DataHandle.getInstance().CreateMyProject(txtTittle.Text, User_ID,"0");
                foreach (string t in txtbox)
                {
                    DataHandle.getInstance().CreateNewProject(txtTittle.Text, t, p, 0);
                    p++;
                }

                this.Dispose();

            }
        }

        public void ButtonAdd()
        {
            Button add = new Button();
            add.Text = "New";
            add.TextAlign = ContentAlignment.MiddleCenter;
            add.BackColor = Color.Salmon;
            add.Margin = new Padding(26, 8, 3, 3);
            add.Size = new System.Drawing.Size(145, 25);
            this.flowLayoutPanel1.Controls.Add(add);

            add.Click += (c, b) =>
            {
                TextBox a = new TextBox();
                a.Name = i.ToString();
                a.Size = new System.Drawing.Size(180, 10);
                a.Margin = new Padding(5, 8, 3, 3);
                a.Text = "Write Something";
                a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                txtbox.Add(a.Text);
                this.flowLayoutPanel1.Controls.Add(a);
                i++;


                a.Leave += (s, e) =>
                {
                    if (_flag == 1)
                    {
                        txtbox.RemoveAt(_e);
                        txtbox.Insert(_e, a.Text);
                    }
                    _e = -1;
                };

                a.Enter += (s, e) =>
                {
                    _flag = 1;
                    _e = Int32.Parse(a.Name);
                    Console.WriteLine(_e);
                    save = _e;
                };

                a.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        addNewItem();
                    }

                };
            };
        }

        public void addNewItem()
        {
            _flag = 0;
            txtbox.RemoveAt(_e);
            this.flowLayoutPanel1.Controls.Clear();
            ButtonAdd();
            i = 0;
            foreach (string text in txtbox)
            {
                TextBox a = new TextBox();
                a.Name = i.ToString();
                a.Size = new System.Drawing.Size(180, 10);
                a.Text = text;
                a.Margin = new Padding(5, 8, 3, 3);
                a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.flowLayoutPanel1.Controls.Add(a);
                i++;

                a.Leave += (d, r) =>
                {
                    if (_flag == 1)
                    {
                        txtbox.RemoveAt(_e);
                        txtbox.Insert(_e, a.Text);
                    }
                    _e = -1;
                };

                a.Enter += (d, r) =>
                {
                    _flag = 1;
                    _e = Int32.Parse(a.Name);
                    Console.WriteLine(_e);
                };

                a.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Delete)
                        addNewItem();
                };
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            timer1._Show();
            this.panel1.Visible = false;
        }
    }
}
