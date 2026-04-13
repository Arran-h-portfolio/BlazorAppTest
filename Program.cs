using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebView.Maui;
using Microsoft.Extensions.Logging;

namespace RotaHub;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        ConfigureGlobalExceptionLogging();

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>();

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddBlazoredLocalStorage();
        builder.Logging.SetMinimumLevel(LogLevel.Debug);

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

    private static void ConfigureGlobalExceptionLogging()
    {
        AppDomain.CurrentDomain.UnhandledException -= OnUnhandledException;
        AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;

        TaskScheduler.UnobservedTaskException -= OnUnobservedTaskException;
        TaskScheduler.UnobservedTaskException += OnUnobservedTaskException;
    }

    private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        WriteStartupLog("AppDomain.CurrentDomain.UnhandledException", e.ExceptionObject as Exception);
    }

    private static void OnUnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
    {
        WriteStartupLog("TaskScheduler.UnobservedTaskException", e.Exception);
    }

    private static void WriteStartupLog(string source, Exception? exception)
    {
        try
        {
            var logPath = Path.Combine(Path.GetTempPath(), "RotaHub-startup.log");
            var message = $"[{DateTime.Now:O}] {source}{Environment.NewLine}{exception}{Environment.NewLine}{Environment.NewLine}";
            File.AppendAllText(logPath, message);
        }
        catch
        {
            // Best effort logging only.
        }

        if (exception is not null)
        {
            Console.Error.WriteLine($"{source}: {exception}");
        }
    }
}
