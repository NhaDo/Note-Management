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

namespace NoteMakingApp.ViewComponents
{
    public partial class NewToDoList : UserControl
    {
        
        static List<string> txtbox { get; set; }
        public static int User_ID;
        static int _e = -1;
        int i = 0;
        int _flag = 0;
        int save;
        
        public NewToDoList()
        {
            txtbox = new List<string>();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            {
                int p = 1;
                if (txtbox.Count() == 0)
                    DataHandle.getInstance().CreateNewToDoList(txtTittle.Text,"",p,0);
                else
                { 
                    DataHandle.getInstance().CreateMyNote(txtTittle.Text, User_ID,0);
                    foreach (string t in txtbox)
                    {
                        DataHandle.getInstance().CreateNewToDoList(txtTittle.Text, t,p,0);
                        p++;
                    }
                    DataHandle.getInstance().ShowNote();
                    
                    this.Dispose();
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs g)
        {
            TextBox a = new TextBox();
            a.Name = i.ToString();
            a.Size = new System.Drawing.Size(150, 10);
            a.Text = "Write Something";
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

         
        }

        private void pictureBox2_Click(object sender, EventArgs y)
        {
            _flag = 0;
            if (_e < 0)
                MessageBox.Show("Vui lòng chọn dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                txtbox.RemoveAt(_e);
                this.flowLayoutPanel1.Controls.Clear();
                i = 0;
                foreach (string o in txtbox)
                {
                    TextBox a = new TextBox();
                    a.Name = i.ToString();
                    a.Size = new System.Drawing.Size(150, 10);
                    a.Text = o;
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
                    };
                }
            }
        }
    }
}
    
