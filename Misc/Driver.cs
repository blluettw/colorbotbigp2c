using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Menu
{

    internal class tonycountrydachina
    {
        public delegate int pDD_btn(int btn);

        public delegate int pDD_whl(int whl);

        public delegate int pDD_key(int ddcode, int flag);

        public delegate int pDD_mov(int x, int y);

        public delegate int pDD_movR(int dx, int dy);

        public delegate int pDD_str(string str);

        public delegate int pDD_todc(int vkcode);

        public delegate int pDD_pid(int pid);

        public pDD_pid pid;

        public pDD_btn btn;

        public pDD_whl whl;

        public pDD_mov mov;

        public pDD_movR movR;

        public pDD_key key;

        public pDD_str str;

        private IntPtr m_hinst;

        [DllImport("Kernel32")]
        private static extern IntPtr LoadLibrary(string dllfile);

        [DllImport("Kernel32")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);

        ~tonycountrydachina()
        {
            if (!m_hinst.Equals(IntPtr.Zero))
            {
                FreeLibrary(m_hinst);
            }
        }

        public async Task<int> Load(string dllfile)
        {
            m_hinst = LoadLibrary(dllfile);
            if (m_hinst.Equals(IntPtr.Zero))
            {
                return -2;
            }
            await Task.Delay(1000);
            return await GetDDfunAddress(m_hinst);
        }

        private async Task<int> GetDDfunAddress(IntPtr hinst)
        {
            await Task.Delay(1000);
            IntPtr procAddress = GetProcAddress(hinst, "DD_btn");
            if (procAddress.Equals(IntPtr.Zero))
            {
                return -1;
            }
            btn = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(pDD_btn)) as pDD_btn;
            if (procAddress.Equals(IntPtr.Zero))
            {
                return -1;
            }
            procAddress = GetProcAddress(hinst, "DD_whl");
            whl = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(pDD_whl)) as pDD_whl;
            if (procAddress.Equals(IntPtr.Zero))
            {
                return -1;
            }
            procAddress = GetProcAddress(hinst, "DD_mov");
            mov = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(pDD_mov)) as pDD_mov;
            if (procAddress.Equals(IntPtr.Zero))
            {
                return -1;
            }
            procAddress = GetProcAddress(hinst, "DD_key");
            key = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(pDD_key)) as pDD_key;
            if (procAddress.Equals(IntPtr.Zero))
            {
                return -1;
            }
            procAddress = GetProcAddress(hinst, "DD_movR");
            movR = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(pDD_movR)) as pDD_movR;
            if (procAddress.Equals(IntPtr.Zero))
            {
                return -1;
            }
            procAddress = GetProcAddress(hinst, "DD_pid");
            pid = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(pDD_pid)) as pDD_pid;
            if (procAddress.Equals(IntPtr.Zero))
            {
                return -1;
            }
            procAddress = GetProcAddress(hinst, "DD_str");
            str = Marshal.GetDelegateForFunctionPointer(procAddress, typeof(pDD_str)) as pDD_str;
            if (procAddress.Equals(IntPtr.Zero))
            {
                return -1;
            }
            procAddress = GetProcAddress(hinst, "DD_todc");
            return 1;
        }
    }
}
