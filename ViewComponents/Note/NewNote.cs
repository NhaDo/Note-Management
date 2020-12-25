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
        
        public static int User_ID;
        
        public NewNote()
        {
            InitializeComponent();
            
            
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            
            if (txtTittle.Text == "")
                MessageBox.Show("Không thể để trống!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (DataHandle.getInstance().checkTittleNote(txtTittle.Text) == false)
                    MessageBox.Show("Tittle đã tồn tại!", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
