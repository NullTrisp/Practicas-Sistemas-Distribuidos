using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Practica_XML_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nconvert => to convert currencies\nexit => to exit program\n");
                switch (Console.ReadLine())
                {
                    case "convert":
                        Console.WriteLine("From:");
                        string from = Console.ReadLine();

                        Console.WriteLine("To:");
                        string to = Console.ReadLine();

                        Console.WriteLine("Value:");
                        decimal value = Convert.ToDecimal(Console.ReadLine());

                        string res = Program.SendMessage(XMLParser.CreateXml(from, to, value));
                        XMLParser parser = XMLParser.ReadXml(res);

                        Console.WriteLine($"\nUnit: {parser.Unit}\nValue: {parser.Value}");
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Select one of the given options!");
                        break;
                }
            }
        }

        static string SendMessage(String message)
        {
            try
            {
                TcpClient client = new TcpClient(ConfigurationManager.AppSettings["host"], Int32.Parse(ConfigurationManager.AppSettings["port"]));
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new Byte[256];

                String responseData = String.Empty;

                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

                stream.Close();
                client.Close();

                return responseData;

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
                return "";
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
                return "";
            }
        }
    }
}
