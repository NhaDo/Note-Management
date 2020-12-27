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

namespace NoteMakingApp.ViewComponents.Network
{
    public partial class ClientItem : UserControl
    {
        private int index;
        public ClientItem()
        {
            InitializeComponent();
        }
        public ClientItem(int id, string name)
        {
            InitializeComponent();
            this.lbName.Text = name;
            index = id;
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
