using Remoting_Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Remoting_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] argus = { 12.34 };

            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel);

            Type requiredType = typeof(MovieTicketInterface);
            MovieTicketInterface remoteObject = (MovieTicketInterface)Activator.GetObject(requiredType, "tcp://localhost:9998/MovieTicketBooking");
            MovieTicketInterface otherRemoteObject = (MovieTicketInterface)Activator.GetObject(requiredType, "tcp://localhost:9998/MovieTicketBooking");
            MovieTicketInterface otherRemoteObjectWithArgs = (MovieTicketInterface)Activator.CreateInstance(requiredType, argus);
            
            Console.WriteLine(remoteObject.GetTicketStatus("Ticket No: 3344"));
            Console.WriteLine(otherRemoteObject.GetTicketStatus("Ticket No: 3345"));
            Console.WriteLine(otherRemoteObjectWithArgs.GetTicketStatus("Ticket No: 13"));
            
            Console.ReadLine();
        }
    }
}
