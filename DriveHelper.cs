public class DriveHelper
{
    [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi)]
    protected static extern int mciSendString(string lpstrCommand,StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);

    public void OpenCDROMDrive()
    {
        mciSendString(“set cdaudio door open”, null, 0, IntPtr.Zero)
    }

    public void CloseCDROMDrive()
    {
        mciSendString(“set cdaudio door close”, null, 0, IntPtr.Zero)
    }
}