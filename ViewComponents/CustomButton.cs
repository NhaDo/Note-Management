﻿using System;
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
                    if (MainDomain.currentInstance.getFlags() == 0)
                    {
                        MessageBox.Show("Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Notes a = DataHandle.getInstance().GetDataFromNote();
                        Form1.getInstance().editNote("Sửa ghi chú",a.Tittle, a.Content);
                    }

                    break;
                case 3:
                    
                    if (MainDomain.currentInstance.getFlags() == 0)
                    {
                        MessageBox.Show("Vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataHandle.getInstance().DeleteNote();
                        DataHandle.getInstance().ShowNote();
                    }
                    break;
            }
        }
    }
}