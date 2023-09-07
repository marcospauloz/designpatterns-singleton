namespace Singleton;

/// <summary>
/// Singleton
/// </summary>
public class Logger
{
    // using lazy initialization
    private static readonly Lazy<Logger> _lazyLogger = new(() => new Logger());
    
    /// <summary>
    /// Instance
    /// </summary>
    public static Logger Instance
    {
        get
        {
            return _lazyLogger.Value;
        }
    }

    protected Logger()
    {
    }

    /// <summary>
    /// Singleton operation
    /// </summary>
    /// <param name="message">The message to be logged</param>
    public void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }
}
