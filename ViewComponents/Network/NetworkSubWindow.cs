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
using System.Net;
using System.Net.Sockets;

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

        private void btnCConnect_Click(object sender, EventArgs e)
        {
            if (tbCServerIP.Text != null)
            {
                try
                {
                    Form1.connection.startClient(IPAddress.Parse(textBox1.Text.Trim()));
                }
                catch
                {

                }
            }
        }
        /*public void UpdateClientList(List<string> n, List<Socket> o)
        {
            ClientItem item;
            foreach (Socket s in o)
            {
                item = new ClientItem(o.IndexOf(s), n[o.IndexOf(s)]);
                item.Location = new System.Drawing.Point(0, this.pnlSClients.Controls.Count * item.Height);
                this.pnlSClients.Controls.Add(item);
            }
        }*/
        delegate void SetClientList(List<string> n, List<Socket> o);

        public void UpdateClientList(List<string> n, List<Socket> o)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.pnlSClients.InvokeRequired)
            {
                SetClientList d = new SetClientList(UpdateClientList);
                this.Invoke(d, new object[] { n, o });
            }
            else
            {
                ClientItem item;
                foreach (Socket s in o)
                {
                    item = new ClientItem(o.IndexOf(s), n[o.IndexOf(s)]);
                    item.Location = new System.Drawing.Point(0, this.pnlSClients.Controls.Count * item.Height);
                    this.pnlSClients.Controls.Add(item);
                }
            }
        }

    }
}
