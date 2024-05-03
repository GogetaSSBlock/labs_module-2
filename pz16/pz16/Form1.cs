using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace pz16
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient = new UdpClient();
        private IPAddress multicastAddress = IPAddress.Parse("224.100.0.1");
        private int multicastPort = 5000;
        private Thread receiveThread;


        public Form1()
        {
            InitializeComponent();
            InitializeChat();
            receiveThread = new Thread(ReceiveMessages);
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void InitializeChat()
        {
            try
            {
                
                multicastAddress = IPAddress.Parse("224.100.0.1");

                
                udpClient = new UdpClient();
                udpClient.JoinMulticastGroup(multicastAddress);

                
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool receivingMessages = true;

        private void ReceiveMessages()
        {
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

                while (receivingMessages)
                {
                    byte[] data = udpClient.Receive(ref remoteEP);
                    string message = Encoding.UTF8.GetString(data);
                    AddMessageToChat(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void AddMessageToChat(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AddMessageToChat(message)));
                return;
            }
            chatRichTextBox.AppendText(message + Environment.NewLine);
        }

        private void SendMessage(string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.Send(data, data.Length, new IPEndPoint(multicastAddress, multicastPort));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                SendMessage(message);
                messageTextBox.Clear();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            receivingMessages = false;
            udpClient?.Close();
        }
    }
}
