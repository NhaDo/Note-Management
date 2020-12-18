using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMakingApp.Models;

namespace NoteMakingApp.ViewComponents
{
    public partial class AvatarEditor : UserControl
    {
        public AvatarEditor()
        {
            InitializeComponent();
        }

        public Image avt;
        private int _id_ = -1;
        private string ImagePath;
        public void setID( int ID)
        {
            _id_ = ID;
        }
        private void bOpen_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            this.avt = Image.FromFile(openFileDialog1.FileName);
            ImagePath = openFileDialog1.FileName;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DataHandle.getInstance().EditAvt(ImagePath, _id_);
            Form1.UpdateAvt();
        }

    }
}
