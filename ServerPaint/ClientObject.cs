using System.Net.Sockets;
using System.Net;
using System.Text;

namespace ServerPaint
{
    public class ClientObject
    {
        protected internal string Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }
        string userName;
        TcpClient client;
        ServerObject server; // объект сервера

        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;
            server = serverObject;
            serverObject.AddConnection(this);
        }

        public void Process()
        {
            try
            {
                Stream = client.GetStream();
                // получаем имя пользователя
                string message = GetText();
                userName = message;

                message = userName + " connected";
                // посылаем сообщение о входе в чат всем подключенным пользователям
                //server.BroadcastMessage(message, this.Id);

                Console.WriteLine(message);
                // в бесконечном цикле получаем сообщения от клиента
                while (true)
                {
                    try
                    {
                        int countBytes = 0;
                        byte[] bytesArr = GetData(ref countBytes);
                        Console.WriteLine($"{userName}: send {countBytes} bytes");
                        if (countBytes == 1)
                        {
                            byte[] clearByte = new byte[] { 1 };
                            server.BroadcastMessage(clearByte, this.Id);
                        }
                        else
                        {
                            server.BroadcastMessage(bytesArr, this.Id);
                        }
                        //message = String.Format("{0}: {1}", userName, message);
                        //Console.WriteLine(message);
                        // server.BroadcastMessage(message, this.Id);
                    }
                    catch
                    {
                        message = String.Format("{0}: disconnected", userName);
                        Console.WriteLine(message);
                        //server.BroadcastMessage(message, this.Id);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // в случае выхода из цикла закрываем ресурсы
                server.RemoveConnection(this.Id);
                Close();
            }
        }

        private string GetText() 
        {
            byte[] data = new byte[64]; // буфер для получаемых данных
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);

            return builder.ToString();
        }

        // чтение входящего сообщения и преобразование в строку
        private byte[] GetData(ref int countBytes)
        {
            byte[] data = new byte[1024]; // буфер для получаемых данных
            int bytes = 0;
            do
            {
                bytes += Stream.Read(data, 0, data.Length);
                countBytes += bytes;
            }
            while (Stream.DataAvailable);

            return data;
        }

        // закрытие подключения
        protected internal void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (client != null)
                client.Close();
        }
    }
}
