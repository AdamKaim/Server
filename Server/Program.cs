using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Text;
using System.IO;

namespace Server
{
    class Program
    {
        public static void Sender(Socket klient)
        {
            //w petli odczytuje linie i wysyla do klienta
            string d = Console.ReadLine();
            byte[] data;

            while (d != "koniec")
            {
                data = Encoding.UTF8.GetBytes(d);
                klient.Send(data);
                d = Console.ReadLine();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Server");
            //utworzenie gniazda, endpoint, accept...
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress adres = IPAddress.Any;
            IPEndPoint endPoint = new IPEndPoint(adres, 6565);

            server.Bind(endPoint);
            server.Listen(5);

            Socket klient = server.Accept();
            //tworzymy watek, ktory tylko wysyla dane do klienta i startujemy
            Thread t = new Thread(() => { Sender(klient); })
                t.Start();
            //w petli odbieramy dane od klienta i wyswietlamy
            while(a > 0)
            {
                byte
            }
        }
    }
}
