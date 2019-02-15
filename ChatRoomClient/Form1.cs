using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatRoomClient
{
    public partial class Form1 : Form
    {
        private bool ClientStatus = false;
        private IPEndPoint ipep;
        private Socket socket;
        private String ip = "192.168.1.101";
        private string name = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            BtnConnect.Text = ClientStatus == false ? "連線" : "斷線";
            ipep = new IPEndPoint(IPAddress.Parse(ip), 8888);
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (ClientStatus)
            {
                socket.Close();
                BtnConnect.Text = "連線";
                ListBChat.Items.Add("中斷連線");
                ClientStatus = false;
            }
            else
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ipep);

                BtnConnect.Text = "斷線";
                ListBChat.Items.Add("連線");
                ClientStatus = true;

                byte[] data = new byte[1024];
                int recv = socket.Receive(data);
                if (recv != 0)
                {
                    name = "" + Encoding.UTF8.GetString(data, 0, recv);
                    Thread t = new Thread(() =>
                    {
                        MessageListener();
                    });
                    t.IsBackground = true;
                    t.Start();
                }
            }
        }

        public void MessageListener()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    int recv = socket.Receive(data);
                    if (recv == 0)
                        break;
                    string package = "" + Encoding.UTF8.GetString(data, 0, recv);
                    string[] msg = package.Split(',');
                    if (msg.Length == 2)
                        ListBChat.Items.Add(msg[0] + " => " + msg[1]);
                }
            }
            catch (Exception e)
            {
                ListBChat.Items.Add("伺服器 斷線");
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string msg = name + "," + TxtSend.Text;
            byte[] data = Encoding.UTF8.GetBytes(msg);
            socket.Send(data);
            TxtSend.Clear();
        }
    }
}
