namespace PicoRuntime;

public static class NativeHost
{
    public static byte[] File_ReadAllBytes(string path)
    {
        return System.IO.File.ReadAllBytes(path);
    }

    public static void Console_WriteLine(string msg = "")
    {
        System.Console.WriteLine(msg);
    }
}