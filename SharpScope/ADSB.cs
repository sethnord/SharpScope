using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using SharpScope;
using System.Threading;
using System.IO;

namespace SharpScope
{
    ///<summary>This class contains all neccesary functions used to process ADS-B data.</summary>
    ///
    class ADSB
    {
        static TcpClient tcpListener;
        static Stream inputStream;
        ///<summary>Creates a TCP connection to an ADS-B data source</summary>
        ///
        public static bool Connect()
        {
            try
            {
                tcpListener = new TcpClient();
                Console.WriteLine("Connecting...");
                Console.WriteLine("Target- IP: " + Program.serverIP + " PORT: " + Program.serverPort);
                tcpListener.Connect(Program.serverIP, Program.serverPort);
                Console.WriteLine("Connection Acquired.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }
            return true;
        }

        public static string GetInputLine()
        {
            inputStream = tcpListener.GetStream();
            Thread.Sleep(1000);
            StreamReader reader = new StreamReader(inputStream);
            String input = reader.ReadLine();
            return input;
        }

        public static bool Close()
        {
            try
            {
                tcpListener.Close();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
