namespace PicoRuntime;

public static class NativeHost
{
    public static System.ConsoleColor Console_ForegroundColor
    {
        get => System.Console.ForegroundColor;
        set => System.Console.ForegroundColor = value;
    }

    public static void Console_WriteLine(string msg = "")
    {
        System.Console.WriteLine(msg);
    }

    public static void Console_Write(string msg)
    {
        System.Console.Write(msg);
    }

    public static void Console_Clear()
    {
        System.Console.Clear();
    }
}