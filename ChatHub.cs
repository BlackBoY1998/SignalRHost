using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRHost
{
    class Akash:Hub
    {
        SqlConnection con;
        DataSet ds;
        DataTable dt;
        SignalREntities se;
        public void Connect(string Name,int U_ID)
        { 
            se = new SignalREntities();
            Campaign c = new Campaign();
            var id = Context.ConnectionId;
            //c.C_ID = Context.ConnectionId;
            c.Name = Name;
            c.U_ID = U_ID;
            se.Campaigns.Add(c);
            se.SaveChanges();

        }
    }
   

}
