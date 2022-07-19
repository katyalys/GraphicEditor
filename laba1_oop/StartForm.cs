using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace laba1_oop
{
    public partial class frmStart : Form
    {

        public frmStart()
        {
            InitializeComponent();
        }

        private void EstablishConnection_Click(object sender, EventArgs e)
        {
            string userName = fieldName.Text;

            IPAddress serverIP;
            if (!IPAddress.TryParse(fieldIP.Text, out serverIP))
            {
                setServerMessage("Incorrect IP server address!");
                setConnectionStatus("error in connection");
                return;
            }

            int serverPort = 0;
            if (!Int32.TryParse(fieldPort.Text, out serverPort))
            {
                setServerMessage("Incorrect port number!");
                setConnectionStatus("error in connection");
                return;
            }

            Form1.client = new TcpClient();
            try
            {
                Form1.client.Connect(serverIP, serverPort);
                setConnectionStatus("connected");
                Form1.stream = Form1.client.GetStream();
                byte[] data = Encoding.Unicode.GetBytes(userName);
                Form1.stream.Write(data, 0, data.Length);

                Thread receiveThread = new Thread(new ThreadStart(Form1.ReceiveMessage));
                receiveThread.Start(); //старт потока
            }
            catch (Exception ex) { }
        }

        public static void setConnectionStatus(string msg)
        {
            lblStatusClient.Text = msg;
        }

        public static void setServerMessage(string msg)
        {
            lblServerMessage.Text = msg;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Form1.buffer[Form1.buffer.Length - 1 ] = 2;
            Form1.ClearImage();
            //Form1.client.Send(Form1.buffer);
        }
    }
}
