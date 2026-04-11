using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Logging;

namespace BlazorAppTest.Components;

public class LoggingErrorBoundary : ErrorBoundary
{
    [Inject] private ILogger<LoggingErrorBoundary>? Logger { get; set; }

    protected override Task OnErrorAsync(Exception exception)
    {
        Logger?.LogError(exception, "Unhandled exception while rendering the Blazor desktop UI.");
        Console.Error.WriteLine(exception.ToString());

        try
        {
            var logPath = Path.Combine(Path.GetTempPath(), "BlazorAppTest-startup.log");
            File.AppendAllText(logPath, $"[{DateTime.Now:O}] UI exception{Environment.NewLine}{exception}{Environment.NewLine}{Environment.NewLine}");
        }
        catch
        {
            // Best effort logging only.
        }

        return Task.CompletedTask;
    }
}
