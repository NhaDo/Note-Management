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
    public partial class NetworkSubWindow : UserControl
    {
        public NetworkSubWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Terminate Server")
            {
                Connection.peer.Close();
                button2.Text = "Generate Server";
                lbSServerIP.Text = "___";
                lbSServerName.Text = "___";
            }
            else
            {
                Form1.connection.startServer();
                button2.Text = "Terminate Server";
                lbSServerIP.Text = Connection.endpoint.Address.ToString();
                lbSServerName.Text = DataHandle.getInstance().getRecentAccount().username;
            }
            
        }
    }
}
