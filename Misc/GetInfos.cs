using System;
using System.Security.Principal;

namespace Utorrent.Misc
{
    static class GetInfos
    {
        public static string ip()
        {
            string ipuser = "Erro ao puxar ip";
            try
            {
                string datetime = DateTime.Now.ToString("hh:mm:ss tt");
                string url = "http://checkip.dyndns.org";
                System.Net.WebRequest req = System.Net.WebRequest.Create(url);
                System.Net.WebResponse resp = req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string response = sr.ReadToEnd().Trim();
                string[] ipAddressWithText = response.Split(':');
                string ipAddressWithHTMLEnd = ipAddressWithText[1].Substring(1);
                string[] ipAddress = ipAddressWithHTMLEnd.Split('<');
                ipuser = ipAddress[0];
            }
            catch { }
            return ipuser;
        }

        public static string hwid()
        {
            string userHWID = WindowsIdentity.GetCurrent().User.Value;
            return userHWID;
        }
    }
}
