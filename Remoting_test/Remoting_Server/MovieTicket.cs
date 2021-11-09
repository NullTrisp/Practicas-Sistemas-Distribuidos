using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remoting_Server
{
    public class MovieTicket : MarshalByRefObject, MovieTicketInterface
    {
        public MovieTicket()
        {
            Console.WriteLine("\nI was created!");
        }
        public string GetTicketStatus(string stringToPrint)
        {
            string returnStatus = "Ticket Confirmed";
            Console.WriteLine("Enquiry for {0}", stringToPrint);
            Console.WriteLine("Sending back status: {0}", returnStatus);
            return returnStatus;
        }
    }
}
