using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Remoting_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ticket Server started...");
            TcpChannel tcpChannel = new TcpChannel(9998);
            ChannelServices.RegisterChannel(tcpChannel, false);
            Type commonInterfaceType = Type.GetType("Remoting_Server.MovieTicket");
            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType,
            "MovieTicketBooking", WellKnownObjectMode.SingleCall);
            System.Console.WriteLine("Press ENTER to quit\n");
            System.Console.ReadLine();
        }
    }
}


