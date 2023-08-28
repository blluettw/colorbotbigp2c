using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Protection.Components
{
    [Obfuscation(Feature = "virtualization", Exclude = false)]
    class AntiDebugger
    {
        public static List<string> pNameData = new List<string>();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetHandleInformation(IntPtr hObject, uint dwMask, uint dwFlags);

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern bool NtClose(IntPtr Handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateMutexA(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool IsDebuggerPresent();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lib);

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern uint NtQueryInformationProcess(SafeHandle hProcess, uint ProcessInfoClass, out uint ProcessInfo, uint nSize, uint ReturnLength);

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern uint NtQueryInformationProcess(SafeHandle hProcess, uint ProcessInfoClass, out IntPtr ProcessInfo, uint nSize, uint ReturnLength);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowTextLengthA(IntPtr HWND);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowTextA(IntPtr HWND, StringBuilder WindowText, int nMaxCount);

        public static bool NtCloseAntiDebug_InvalidHandle()
        {
            try
            {
                NtClose((IntPtr)0x1231222L);
                return false;
            }
            catch
            {
                return true;
            }
        }

        public static bool WebSniffers()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

            HttpWebRequest.DefaultWebProxy = new WebProxy();
            WebRequest.DefaultWebProxy = new WebProxy();

            if (GetModuleHandle("HTTPDebuggerBrowser.dll") != IntPtr.Zero || GetModuleHandle("FiddlerCore4.dll") != IntPtr.Zero || GetModuleHandle("RestSharp.dll") != IntPtr.Zero || GetModuleHandle("Titanium.Web.Proxy.dll") != IntPtr.Zero)
            {
                return true;
            }

            return false;
        }

        public static bool NtCloseAntiDebug_ProtectedHandle()
        {
            IntPtr hMutex = CreateMutexA(IntPtr.Zero, false, new Random().Next(0, 9999999).ToString());
            uint HANDLE_FLAG_PROTECT_FROM_CLOSE = 0x00000002;
            SetHandleInformation(hMutex, HANDLE_FLAG_PROTECT_FROM_CLOSE, HANDLE_FLAG_PROTECT_FROM_CLOSE);
            try
            {
                NtClose(hMutex);
                return false;
            }
            catch
            {
                return true;
            }
        }

        public static bool DebuggerIsAttached()
        {
            return Debugger.IsAttached;
        }

        public static bool IsDebuggerPresentCheck()
        {
            if (IsDebuggerPresent())
                return true;
            return false;
        }

        public static bool NtQueryInformationProcessCheck_ProcessDebugFlags()
        {
            uint ProcessDebugFlags = 0;
            NtQueryInformationProcess(Process.GetCurrentProcess().SafeHandle, 0x1F, out ProcessDebugFlags, sizeof(uint), 0);
            if (ProcessDebugFlags == 0)
                return true;
            return false;
        }

        public static bool NtQueryInformationProcessCheck_ProcessDebugPort()
        {
            uint DebuggerPresent = 0;
            uint Size = sizeof(uint);
            if (Environment.Is64BitProcess)
                Size = sizeof(uint) * 2;
            NtQueryInformationProcess(Process.GetCurrentProcess().SafeHandle, 7, out DebuggerPresent, Size, 0);
            if (DebuggerPresent != 0)
                return true;
            return false;
        }

        public static bool NtQueryInformationProcessCheck_ProcessDebugObjectHandle()
        {
            IntPtr hDebugObject = IntPtr.Zero;
            uint Size = sizeof(uint);
            if (Environment.Is64BitProcess)
                Size = sizeof(uint) * 2;
            NtQueryInformationProcess(Process.GetCurrentProcess().SafeHandle, 0x1E, out hDebugObject, Size, 0);
            if (hDebugObject != IntPtr.Zero)
                return true;
            return false;
        }

        public static bool FindWindowAntiDebug()
        {
            Process[] GetProcesses = Process.GetProcesses();
            foreach (Process GetWindow in GetProcesses)
            {
                string[] BadWindowNames = { "ilspy", "x32dbg", "x64dbg", "windbg", "ollydbg", "dnspy", "immunitydebugger", "hyperdbg", "cheatengine", "idapro", "processhacker", "extreme dumper", "httpdebugger" };
                foreach (string BadWindows in BadWindowNames)
                {
                    if (GetWindow.MainWindowTitle.ToLower().Contains(BadWindows))
                    {
                        pNameData.Add(BadWindows);
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool GetForegroundWindowAntiDebug()
        {
            string[] BadWindowNames = { "ilspy", "x32dbg", "x64dbg", "windbg", "ollydbg", "dnspy", "immunity debugger", "hyperdbg", "debug", "debugger", "cheat engine", "idapro", "process hacker", "extreme dumper", "http debugger" };
            IntPtr HWND = GetForegroundWindow();
            int WindowLength = GetWindowTextLengthA(HWND);
            if (WindowLength != 0)
            {
                StringBuilder WindowName = new StringBuilder(WindowLength + 1);
                GetWindowTextA(HWND, WindowName, WindowLength + 1);
                foreach (string BadWindows in BadWindowNames)
                {
                    if (WindowName.ToString().ToLower().Contains(BadWindows))
                    {
                        pNameData.Add(BadWindows);
                        return true;
                    }
                }
            }
            return false;
        }

        private static long CONTEXT_DEBUG_REGISTERS = 0x00010000L | 0x00000010L;
    }
}
