using System;
using ExpressTimezone;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientTcp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SendMessageFromSocket(11000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
        static void SendMessageFromSocket(int port)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            byte[] bytes = new byte[1024];
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            sender.Connect(ipEndPoint);
            Console.WriteLine("==========================");
            Console.WriteLine("Виберіть потрібний часовий пояс:");
            Console.WriteLine("1 - західноєвропейський час");
            Console.WriteLine("2 - всесвітній координований час");
            Console.WriteLine("3 - середній час за Грінвічем");
            Console.WriteLine("4 - центральноєвропейський час");
            Console.WriteLine("5 - Часовий пояс користувача");
            DateTime time = DateTime.Now;
            var timezoneUser = Console.ReadLine();
            string message = null;
            switch (timezoneUser)
            {
                case "1":
                    message = time.UTCToRegionalTime("WET").ToString();
                    break;
                case "2":
                    message = time.UTCToRegionalTime("UTC").ToString();
                    break;
                case "3":
                    message = time.UTCToRegionalTime("GMT").ToString();
                    break;
                case "4":
                    message = time.UTCToRegionalTime("CET").ToString();
                    break;
                case "5":
                    message = time.ToString();
                    break;
            }
            Console.WriteLine("Сокет з’єднується з {0} ", sender.RemoteEndPoint.ToString());

            byte[] msg = Encoding.UTF8.GetBytes(message);
            int bytesSent = sender.Send(msg);
            int bytesRec = sender.Receive(bytes);

            Console.WriteLine("\nВідповідь від сервера: {0}\n\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));

            if (message.IndexOf("<TheEnd>") == -1)
                SendMessageFromSocket(port);
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
    }
}
