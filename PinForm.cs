using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NoteMakingApp.Models;

namespace NoteMakingApp
{
    public partial class PinForm : Form
    {
        public static PinForm currentInstance { get; set; }

        public PinForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(366, 222);
            currentInstance = this;
        }
        int _flags = 0;


        public int getFlags()
        {
            return _flags;
        }

        public void setTittle(string text)
        {
            this.Text = text;
        }

        public void setContent(string text)
        {
            this.TextBox.Text = text;
        }

        private void PinForm_ClientSizeChanged(object sender, EventArgs e)
        {
            this.TextBox.Size = this.ClientSize;
        }
        public void setName(int id)
        {
            currentInstance.Name = id.ToString();
            this._flags = id;
        }

        int _isPinned =0 ;

        public int getId()
        {
            _isPinned = Int32.Parse(this.Name);
            return _isPinned;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            DataHandle.getInstance().EditNote(this.Text, this.TextBox.Text);
        }

        private void PinForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataHandle.getInstance().ShowNote();
            this.Dispose();
        }
    }
}
