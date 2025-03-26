using System;

public enum LogLevel
{
    Comment,
    Warning,
    Error
}

public class LoggerSingleton
{
    private static readonly LoggerSingleton _instance = new LoggerSingleton();

    // Private constructor to prevent external instantiation
    private LoggerSingleton() { }

    public static LoggerSingleton Instance => _instance;

    public void Log(LogLevel level, string message)
    {
        switch (level)
        {
            case LogLevel.Comment:
                Console.ResetColor();
                Console.WriteLine($"Comment: {message}");
                break;
            
            case LogLevel.Warning:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Warning: {message}");
                Console.ResetColor();
                break;

            case LogLevel.Error:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {message}");
                Console.ResetColor();
                Environment.Exit(1); // Stops program execution on error
                break;
        }
    }
}

// Example Usage
class Program
{
    static void Main()
    {
        var logger = LoggerSingleton.Instance;

        logger.Log(LogLevel.Comment, "This is a comment log.");
        logger.Log(LogLevel.Warning, "This is a warning log.");
        logger.Log(LogLevel.Error, "This is an error log.");
        logger.Log(LogLevel.Comment, "This will not be executed.");
    }
}