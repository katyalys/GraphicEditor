using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            Program.startForm = this;
        }

        public static IPAddress serverIP;
        public static int serverPort = 0;

        private void btnEstablishConnection_Click(object sender, EventArgs e)
        {
           // IPAddress serverIP;
            if (!IPAddress.TryParse(fieldIP.Text, out serverIP))
            {
                setServerMessage("Некорректный IP адрес сервера!");
                return;
            }

           // int serverPort = 0;
            if (!Int32.TryParse(fieldPort.Text, out serverPort))
            {
                setServerMessage("Некорректный номер порта!");
                return;
            }

            var server = new TCPServer(serverIP, serverPort);
            Task.Run(() => server.Start());

            // new
            //int result = 0;
            //Int32.TryParse(tbClientNum.Text, out result);
            //for (int i = 0; i < result; i++)
            //{
            //    var server = new TCPServer(serverIP, serverPort);
            //    Task.Run(() => server.Start());
            //}
        }
        
        public static void MultipleClients()
        {
            int result = 0;
            Int32.TryParse(tbClientNum.Text, out result);
            for (int i = 0; i < result - 1; i++)
            {
              //  Thread newThread = new Thread(new ThreadStart(TCPServer.Start()));
             //   newThread.Start();
            }
        }
        public static void setConnectionStatus(string msg)
        {
          //  lblStatusServer.Text = msg;
        }

        public static void setServerMessage(string msg)
        {
          //  lblServerMessage.Text = msg;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }


    }
}
