using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NoteMakingApp.Models
{
    public class Peer
    {
        public Socket socket;
        public String name;
        public Peer(Socket s, String n)
        {
            this.socket = s;
            this.name = n;
        }
    }
    public class Connection
    {
        private static int port = 8888;
        public static IPEndPoint endpoint;
        public static Socket peer;
        public static List<Socket> others;
        static List<Peer> peers;
        static List<string> p;
        public static IPAddress serverIP;
        public static Socket getPeer()
        {
            return peer;
        }
        public int startServer()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return 0;
            }
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            IPAddress localIP = host
                                .AddressList
                                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
            endpoint = new IPEndPoint(localIP, port);
            serverIP = endpoint.Address;
            peer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            peer.Bind(endpoint);
            others = new List<Socket>();

            Thread listen = new Thread(() => {
                try {
                    while (true)
                    {
                        peer.Listen(100);
                        Socket client = peer.Accept();
                        others.Add(client);

                        Thread rcv = new Thread(SReceive);
                        rcv.IsBackground = true;
                        rcv.Start(client);
                    }
                }
                catch
                {
                    
                   /* host = Dns.GetHostEntry(Dns.GetHostName());

                    localIP = host
                                        .AddressList
                                        .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);*/
                    endpoint = new IPEndPoint(IPAddress.Any, port);
                    serverIP = endpoint.Address;
                    peer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                }


            });
            listen.IsBackground = true;
            listen.Start();
            return 1;
        }
        public int startClient(IPAddress svIP)
        {
            endpoint = new IPEndPoint(svIP, port);
            peer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                peer.Connect(endpoint);
                SendStatus("CREATE CONNECTION_" + DataHandle.getInstance().getRecentAccount().username);
            }
            catch
            {
                MessageBox.Show("Cannot connect to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            Thread listen = new Thread(CReceive);
            listen.IsBackground = true;
            listen.Start();
            return 1;
        }
        public void SendStatus(string stt)
        {
            string msg = "STATUS_" + stt;
            peer.Send(SerializeMsg(msg));
        }
        public void CSendNote(Notes nt)
        {
            string msg = "NOTE_" + nt.id.ToString() + "_" + nt.Tittle + "_" + nt.user_id.ToString();
            peer.Send(SerializeMsg(msg));
        }
        public void CReceive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    peer.Receive(data);

                    string msg = (string)DeserializeMsg(data);
                }
                
            }
            catch
            {
                Close();
            }
            
        }
        public void DistributeNote(Notes nt)
        {
            foreach(Socket other in others)
            {
                SSendNote(other, nt);
            }
        }
        public void SSendNote(Socket other, Notes nt)
        {
            string msg = "NOTE_" + nt.id.ToString() + "_" + nt.Tittle + "_" + nt.user_id.ToString();
            other.Send(SerializeMsg(msg));
        }
        public void DistributeAccount(Account acc, List<PersonalDetail> dtls)
        {
            foreach (Socket other in others)
            {
                SSendAccount(other, acc, dtls);
            }
        }
        public void SSendAccount(Socket other, Account acc, List<PersonalDetail> dtls)
        {
            string msg = "ACCOUNT_" + acc.id.ToString() + "_"
                                    + acc.password.ToString() + "_"
                                    + acc.username.ToString() + "_"
                                    + acc.created.ToString();
            other.Send(SerializeMsg(msg));
            msg = "DETAILS_" + dtls.Count.ToString();
            foreach(PersonalDetail d in dtls)
            {
                msg += "_" + d.id.ToString()
                    + "_" + d.subcategory.ToString()
                    + "_" + d.content.ToString()
                    + "_" + d.category.ToString()
                    + "_" + d.account.ToString();
            }
        }
        public void SReceive(Object dest)
        {
            Socket other = dest as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    other.Receive(data);

                    string msg = (string)DeserializeMsg(data);
                    string[] tokens = msg.Split('_');
                    if (tokens[0] == "STATUS")
                    {
                        p.Add(tokens[2]);
                    }

                    Form1.getInstance().networkSubWindow1.UpdateClientList(p, others);
                }
            }
            catch
            {
                others.Remove(other);
                other.Close();
            }

        }
        public void ExcludeClient(int id)
        {
            if (others.Count != 0)
            {
                try
                {
                    others.RemoveAt(id);
                    p.RemoveAt(id);
                    Form1.getInstance().networkSubWindow1.UpdateClientList(p, others);

                }
                catch
                {

                }
            }
        }
        private byte[] SerializeMsg(Object msg)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, msg);
            return stream.ToArray();
        }
        private object DeserializeMsg(byte[] msg)
        {
            MemoryStream stream = new MemoryStream(msg);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
        private void Close()
        {
            SendStatus("DISCARD CONNECTION_" + DataHandle.getInstance().getRecentAccount().username);
            if (others.Count != 0)
            {
                foreach (Socket other in others)
                {
                    SendStatus("DISCARD CONNECTION_" + DataHandle.getInstance().getRecentAccount().username);
                }
            }
            others.Clear();
            peer.Close();
        }
    }
}
