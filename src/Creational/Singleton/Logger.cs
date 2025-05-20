namespace Singleton;

public sealed class Logger
{
    private static readonly Lazy<Logger> _instance =
        new(() => new Logger(), isThreadSafe: true);

    private Logger() { }

    public static Logger Instance => _instance.Value;

    public void Log(string message) =>
        Console.WriteLine($"[{DateTime.UtcNow:O}] {message}");
}
