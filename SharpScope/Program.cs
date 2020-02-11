using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpScope;
using System.Threading;

namespace SharpScope
{
    class Program
    {
        public static string serverIP = "127.0.0.1";
        public static int serverPort = 30003;
        static void Main(string[] args)
        {
            //Begin by creating a TCP connection on port 30003 to the ADS-B data source.
            Console.WriteLine("Establishing connection to ADS-B source...");
            bool connected = ADSB.Connect();
            if(connected == true)
            {
                Console.WriteLine("Connection successful.");
            }
            else
            {
                Console.WriteLine("Could not connect.");
            }
        }
    }
}
