using System;

public enum LogLevel
{
    Comment,
    Warning,
    Error
}

public static class LoggerStatic
{
    public static void Log(LogLevel level, string message)
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
        LoggerStatic.Log(LogLevel.Comment, "This is a comment log.");
        LoggerStatic.Log(LogLevel.Warning, "This is a warning log.");
        LoggerStatic.Log(LogLevel.Error, "This is an error log.");
        LoggerStatic.Log(LogLevel.Comment, "This will not be executed.");
    }
}