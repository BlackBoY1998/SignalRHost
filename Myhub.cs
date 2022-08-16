using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRHost
{
    [HubName("MyHub")]
    public class MyHub : Hub
    {
        public string GetDetails(string s)
        {
            return "Hi" + s;
        }

        public string GetData(string name,string Age)
        {
            return "Hii " + name + "Your Age is" + Age;
        }

        public string GetTerminalName(string s)
        {
            return "Hi" + s;
        }

    }
}
