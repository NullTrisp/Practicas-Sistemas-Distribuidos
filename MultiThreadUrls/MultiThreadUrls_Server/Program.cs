using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadUrls_Server
{
    class Program
    {
        public static WebClient client = new WebClient();
        public List<string> list = new List<string>(client.DownloadString(@"https://ia800203.us.archive.org/30/items/UrlListForAlexissample/url_list_small.txt").Split('\n'));
        private static readonly int threadNum = 10;
        static void Main(string[] args)
        {
            Thread myThread;

            for (int i = 0; i < threadNum; i++)
            {
                myThread = new Thread(new ThreadStart(Handler.ThreadFunc));
                myThread.Name = String.Format("Thread {0}", i + 1);
            }
            Console.ReadLine();
        }
    }

    class Handler
    {
        public static void ThreadFunc()
        {

        }
    }
    /**
     * q es .net
     * q es un sis dist
     * sis distriubiodos
     * sockets o obj remotos
     */
}


