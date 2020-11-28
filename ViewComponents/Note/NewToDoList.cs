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
      

        public int i = 1;
        public int flag = 0;
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
                if (txtbox == null)
                    DataHandle.getInstance().CreateNewToDoList(txtTittle.Text, "");
                else
                {
                    foreach (string t in txtbox)
                    {
                        DataHandle.getInstance().CreateNewToDoList(txtTittle.Text, t);
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
            a.Text = "Something " + i.ToString();
            this.flowLayoutPanel1.Controls.Add(a);
            
            i++;
            
            
            a.Leave += (s, e) =>
            {
                if (flag+2 < i)
                {
                    txtbox.Insert(flag - 1, a.Text);
                    Console.WriteLine("Sua du lieu");
                }
                else
                {
                    txtbox.Add(a.Text);
                    Console.WriteLine("Them du lieu");
                }
                
            };

            a.Enter += (s, e) =>
            {
                
                flag = Int32.Parse(a.Name);
                Console.WriteLine("flag: " + flag);
                Console.WriteLine("i: " + i);
                

            };

         
        }
    }
}
    
