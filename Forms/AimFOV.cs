using Utorrent.Misc;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Utorrent
{

    public partial class AimFOV : Form
    {

        Graphics g;

        public static IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong)
        {
            if (IntPtr.Size == 8)
                return SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
            else
                return new IntPtr(SetWindowLong32(hWnd, nIndex, dwNewLong.ToInt32()));
        }

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int SetWindowLong32(HandleRef hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

        public AimFOV()
        {
            InitializeComponent();
            refreshTimer.Start();
        }

        private void HideFromAltTab()
        {
            int exStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
            exStyle |= 0x00000080;
            SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle);
        }


        private void FormOverlay_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackColor = Color.Fuchsia;
                this.TransparencyKey = Color.Fuchsia;
                this.TopMost = true;
                this.MaximizeBox = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.ShowInTaskbar = false;
                HideFromAltTab();



                HandleRef handleRef = new HandleRef(this, this.Handle);
                IntPtr initialStyle = GetWindowLongPtr(this.Handle, -20);
                int test = (int)initialStyle | 0x80000 | 0x20;
                SetWindowLongPtr(handleRef, -20, new IntPtr(test));
            }
            catch
            {
                this.Close();
                return;
            }
        }



        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddMilliseconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern IntPtr MonitorFromWindow(IntPtr hwnd, uint dwFlags);

        [DllImport("User32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

        public const uint WDA_MONITOR = 1;
        public const uint WDA_EXCLUDEFROMCAPTURE = 0x11;
        public const int MONITOR_DEFAULTTOPRIMARY = 1;
        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_TOOLWINDOW = 0x80;

        public void stproofenablefov()
        {
            SetWindowLong(Handle, GWL_EXSTYLE, (int)(GetWindowLong(Handle, GWL_EXSTYLE) | WS_EX_TOOLWINDOW));
            IntPtr hMonitor = MonitorFromWindow(Handle, MONITOR_DEFAULTTOPRIMARY);
            SetWindowDisplayAffinity(Handle, (uint)(WDA_MONITOR | WDA_EXCLUDEFROMCAPTURE));
        }

        public void stproofdisablefov()
        {
            config.streamproof = false;
            SetWindowLong(Handle, GWL_EXSTYLE, (int)(GetWindowLong(Handle, GWL_EXSTYLE) & ~WS_EX_TOOLWINDOW));
            SetWindowDisplayAffinity(Handle, 0);
        }

        bool dfovproof;


        public void FormOverlayPaint(object sender, PaintEventArgs e)
        {
            if (this.IsDisposed || this.Disposing)
            {
                Close();
                return;
            }

            if (config.streamproof)
            {
                dfovproof = true;
                stproofenablefov();
            }
            else if (!config.streamproof && dfovproof)
            {
                stproofdisablefov();
                dfovproof = false;
            }

            Top = (config.screenHeight - config.fov_y) / 2;
            Left = (config.screenWidth - config.fov_x) / 2;
            Size = new Size(config.fov_x + 50, config.fov_y + 50);

            g = e.Graphics;
            Color col = Color.FromArgb(config.drawfovcolor);
            Pen New = new Pen(col)
            {
                Width = 1
            };
            e.Graphics.Clear(Color.Fuchsia);
            g.DrawEllipse(New, 0, 0, config.fov_x, config.fov_y);
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

    }
}