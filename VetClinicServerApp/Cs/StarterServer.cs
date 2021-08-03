using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace VetClinicServerApp
{
    class StarterServer
    {
        const int port = 8088; // порт для прослушивания подключений
        public void Start()
        {
            TcpListener server = null;
            try
            {
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                server = new TcpListener(localAddr, port);

                // запуск слушателя
                server.Start();


                while (true)
                {
                    //    Console.WriteLine("Ожидание подключений... ");

                    // получаем входящее подключение
                    TcpClient client = server.AcceptTcpClient();
                    //    Console.WriteLine("Подключен клиент. Выполнение запроса...");

                    // получаем сетевой поток для чтения и записи
                    NetworkStream stream = client.GetStream();
                }

            }

            finally
            {
                if (server != null)
                    server.Stop();
            }
        }
    }
}
