using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.Owin.Hosting;
using System.Net;
using System.Net.Sockets;

namespace SignalRHost
{
    class Program
    {
        private static string GetIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            return host.AddressList.First(x => x.AddressFamily == AddressFamily.InterNetwork).ToString();
        }
        static void Main(string[] args)
        {
            //string url = "http://localhost:8077";
            //string url = "http://172.16.2.72:8500";
            var options = new StartOptions
            {
                ServerFactory = "http://172.16.2.72",
                Port = 8500
            };
  
            var url = "http://*:" + 8500;
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();
            }

            System.Console.Read();
        }
    }
}
