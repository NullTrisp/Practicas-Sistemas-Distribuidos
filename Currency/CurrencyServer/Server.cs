using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CurrencyServer
{
    class Server
    {
        public static void Lift()
        {
            try
            {
                // Hacemos que el TcpListener escuche en host:port.
                TcpListener server = new TcpListener(IPAddress.Parse(ConfigurationManager.AppSettings["host"]), Int32.Parse(ConfigurationManager.AppSettings["port"]));
                server.Start();
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    ReqHandler reqHandler = new ReqHandler(client);
                    Thread thread = new Thread(new ThreadStart(reqHandler.Handle));
                    thread.Start();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }
    }

    class ReqHandler
    {
        private readonly TcpClient client;
        public ReqHandler(TcpClient client)
        {
            this.client = client;
        }

        public void Handle()
        {
            Byte[] bytes = new Byte[256];
            NetworkStream stream = this.client.GetStream();
            Int32 i = stream.Read(bytes, 0, bytes.Length);
            string data = Encoding.ASCII.GetString(bytes, 0, i).Trim();
            Console.WriteLine(data);


            Thread.Sleep(5000);

            var convertor = XMLConverter.ReadXml(data);

            if (convertor.exchange == XMLConverter.DollarToEuro)
            {
                data = XMLConverter.CreateXmlResponse(Converter.ToEur(convertor.value), Converter.Euro);
            }
            else if (convertor.exchange == XMLConverter.EuroToDollar)
            {
                data = XMLConverter.CreateXmlResponse(Converter.ToDollar(convertor.value), Converter.Dollar);
            }
            else
            {
                data = XMLConverter.CreateXmlErrorResponse("ERROR: Divisa no reconocida " + convertor.exchange);
            }

            Byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
            Console.WriteLine(msg.ToString());
            stream.Write(msg, 0, msg.Length);
            this.client.Close();
        }
    }
}
