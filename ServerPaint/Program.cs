using System;
using System.Net;
using System.Threading;

namespace ServerPaint
{
    class Program
    {
        static ServerObject server; // сервер
        static Thread listenThread; // потока для прослушивания
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter server ip: ");
                var tmpServerIp = Console.ReadLine();
                IPAddress serverIP;
                if (!IPAddress.TryParse(tmpServerIp, out serverIP))
                {
                    //setServerMessage("Некорректный IP адрес сервера!");
                    Console.WriteLine("Incorrect ip address");
                    return;
                }

                Console.Write("Enter server port: ");
                var tmpServerPort =Console.ReadLine();
                int serverPort = 0;
                if (!Int32.TryParse(tmpServerPort, out serverPort))
                {
                    Console.WriteLine("Incorrect server port");
                    return;
                }


                server = new ServerObject(serverIP, serverPort);
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start(); //старт потока
            }
            catch (Exception ex)
            {
                server.Disconnect();
                Console.WriteLine(ex.Message);
            }
        }
    }
}