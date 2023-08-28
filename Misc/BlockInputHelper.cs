using System.Runtime.InteropServices;

public class BlockInputHelper
{
    [DllImport("user32.dll", SetLastError = true)]
    static extern bool BlockInput(bool fBlockIt);


    public static void Block(bool block)
    {
        BlockInput(block);
    }
}