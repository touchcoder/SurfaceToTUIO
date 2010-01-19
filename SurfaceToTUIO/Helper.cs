using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Net;

namespace SurfaceToTUIO
{
    public class Helper
    {
        public static StringCollection getLocalIP()
        {
            StringCollection localIP = new StringCollection();
            string localHostName = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(localHostName);
            foreach (IPAddress ipAddr in hostEntry.AddressList)
            {
                localIP.Add(ipAddr.ToString());
            }
            return localIP;
        }
    }
}
