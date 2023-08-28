using System.Runtime.InteropServices;

namespace iTunes.Misc
{
    static class Wallpaper
    {

        public const int SPI_SETDESKWALLPAPER = 20;
        public const int SPIF_UPDATEINIFILE = 1;
        public const int SPIF_SENDCHANGE = 2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public static void changedesktopwalppaper(string imagepath)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imagepath, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
        }
    }
}
