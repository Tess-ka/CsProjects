using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace VetClinicApp
{
    class Starter
    {
        private const int port = 8088;
        private const string server = "127.0.0.1";

        public void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormVet());
        }

        public void InitConnection()
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);

                byte[] data = new byte[256];
                //Byte[] data = System.Text.Encoding.ASCII.GetBytes(Message);
                StringBuilder response = new StringBuilder();
                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer.
                stream.Write(data, 0, data.Length);



                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable); // пока данные есть в потоке

                //Console.WriteLine(response.ToString());

                // Закрываем потоки
                stream.Close();
                client.Close();

            }
            //catch (SocketException e)
            //{
            //    Console.WriteLine("SocketException: {0}", e);
            //}
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }

            //Console.WriteLine("Запрос завершен...");
            //Console.Read();
        }
    }
}
