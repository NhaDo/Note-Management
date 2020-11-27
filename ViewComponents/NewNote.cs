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
    public partial class NewNote : UserControl
    {
        public static NewNote curentInstance { get; set; }
        public static int User_ID;
        
        public NewNote()
        {
            InitializeComponent();
            curentInstance = this;
            
        }


        private void btnOk_Click(object sender, EventArgs e)
        {

            if (txtTittle.Text == "")
                MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataHandle.getInstance().CreateNewNote(
                    new Notes()
                    {
                        Tittle = txtTittle.Text,
                        Content = txtContent.Text,
                        user_id = User_ID
                    });

                DataHandle.getInstance().ShowNote();
                this.Dispose();

                /*
                    if (txtTittle.Text == "")
                        MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        DataHandle.getInstance().EditNote(txtTittle.Text,txtContent.Text);
                        DataHandle.getInstance().ShowNote();
                        this.Dispose();
                    }
                    */

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setValue(string a , string b, string c)
        {
            this.lbMain.Text = a;
            
            this.txtTittle.Text = b;
            this.txtContent.Text = c;
        }

        
    }
}
