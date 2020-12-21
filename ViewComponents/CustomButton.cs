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
    public partial class CustomButton : UserControl
    {
        
        public int fun;
      
        public CustomButton()
        {
            InitializeComponent();
            this.CustomBtn.Text = "";
            this.CustomBtn.FlatAppearance.BorderSize = 0;
            this.lbDetail.BackColor = Color.Yellow;
            this.lbDetail.Visible = false;
            this.lbDetail.BorderStyle = BorderStyle.FixedSingle;
            this.CustomBtn.ImageList = imageList;
            
            

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.CustomBtn.Cursor = Cursors.Hand;
            this.CustomBtn.ImageIndex += 1;

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.lbDetail.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.lbDetail.Visible = false;
            this.CustomBtn.Cursor = Cursors.Default;
            this.CustomBtn.ImageIndex -= 1;
        }

        public void getText(string tex)
        {
            this.lbDetail.Text = tex;
        }


        public void setImage(int index)
        {
            this.CustomBtn.ImageIndex = index;
        }

        public void setFunction(int index)
        {
            this.fun = index;
            this.CustomBtn.Name = index.ToString();
        }

        


        public int getFun()
        {
            fun = Int32.Parse(this.CustomBtn.Name);
            return fun;
        }



        public void button_Click(object sender, EventArgs e)
        {
            switch (fun)
            {
                case 1:
                    Form1.getInstance().ShowTypeNote();
                    //Form1.getInstance().NewNote();
                    break;
                case 2:
                    if (Form1.type == 0 )
                    {
                        MessageBox.Show("Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        switch (Form1.type)
                        {
                            case 1:
                                Notes a = DataHandle.getInstance().GetDataFromNote();
                                Form1.getInstance().editNote( a.Tittle, a.Content);
                                break;
                            case 2:
                                ToDoLists b = DataHandle.getInstance().GetDataToDoList();
                                if (b==null)
                                    MessageBox.Show("Choose note to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                    Form1.getInstance().editToDoList(b.Tittle, b.item);
                                break;
                            case 3:
                                Reminders c = DataHandle.getInstance().GetDateReminder();
                                Form1.getInstance().EditReminder(c.Tittle, c.Content, c.Time, c.Check);
                                break;

                        }
                        
                        
                    }
                    

                    break;
                case 3:
                    
                    if (MainDomain.currentInstance.getFlags() == 0)
                    {
                        MessageBox.Show("Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        switch (Form1.type)
                        {
                            case 1:
                                DataHandle.getInstance().DeleteNote();
                                DataHandle.getInstance().ShowNote();
                                break;
                            case 2:
                                DataHandle.getInstance().DeleteToDoList();
                                DataHandle.getInstance().ShowNote();
                                break;
                            case 3:
                                DataHandle.getInstance().DeleteReminder();
                                DataHandle.getInstance().ShowNote();
                                break;
                        }
                    }
                    break;
            }
        }
    }
}