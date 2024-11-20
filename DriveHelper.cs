using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

public static class DriveHelper
{
    [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
    protected static extern int mciSendString(string lpstrCommand,StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);

    public static void OpenCDROMDrive()
    {
        mciSendString(“set cdaudio door open”, null, 0, IntPtr.Zero)
    }

    public static void CloseCDROMDrive()
    {
        mciSendString(“set cdaudio door close”, null, 0, IntPtr.Zero)
    }
}
