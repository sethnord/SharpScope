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
        public static bool exit = false; //This is used to exit our main loop.
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
                ADSB.Close();
                Environment.Exit(0);
            }


            //Now that we have connected to the server, we can start receiving data.
            new Thread(() =>
            {
                while(exit == false)
                {
                    string inputLine = ADSB.GetInputLine();
                    Console.WriteLine(inputLine); //This pulls the data line by line- each line represents one message
                    Thread.Sleep(10); //This makes sure we don't pull half written lines, which can mess up our interpretation
                    //With the data in hand, we'll send it to a method that parses and processes it.
                    ADSB.ProcessMessage(inputLine);
                }
            }).Start();
        }
    }
}
