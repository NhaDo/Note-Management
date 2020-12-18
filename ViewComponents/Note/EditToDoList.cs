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
        static int _e = -1;
        static List<ItemTDLs> eitem { get; set; }
        static ItemTDLs save { get; set; }
        public EditToDoList()
        {
            InitializeComponent();
        }

        public void setValue(string name, List<ItemTDLs> item)
        {
            eitem = new List<ItemTDLs>(item);
            this.txtTittle.Text = name;
            foreach (ItemTDLs t in item)
            {
                ItemTDL i = new ItemTDL();
                i.Name = _flag.ToString();
                //i.Name = t.STT.ToString();
                i.setValue(t.Content,t.STT,t.check);
                _flag++;
                i.edit();
                this.flowLayoutPanel1.Controls.Add(i);

                i.checkbox.Enter += (s, e) =>
                {
                    _e = Int32.Parse(i.Name);
                    //Console.WriteLine(_e);
                    save = eitem.ElementAt(_e);
                    Console.WriteLine(i.checkbox.Checked);
                };

                i.checkbox.Leave += (s, e) =>
                {
                    save.check = i.checkbox.Checked;
                    eitem.RemoveAt(_e);
                    eitem.Insert(_e, save);
                    
                };

                i.textBox1.Enter += (s, e) =>
                {
                    _e = Int32.Parse(i.Name);
                    //Console.WriteLine(_e);
                    save = eitem.ElementAt(_e);
                    
                };

                i.textBox1.Leave += (s, e) =>
                {
                    save.Content = i.textBox1.Text;
                    eitem.RemoveAt(_e);
                    eitem.Insert(_e, save);
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
            {
                DataHandle.getInstance().EditToDoList(txtTittle.Text, eitem);
                DataHandle.getInstance().ShowNote();
                this.Dispose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
