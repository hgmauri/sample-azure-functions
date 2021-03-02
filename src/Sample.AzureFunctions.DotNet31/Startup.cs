using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sample.AzureFunctions.DotNet31;
using Serilog;
using Serilog.Events;
using Serilog.Extensions.Logging;

[assembly: FunctionsStartup(typeof(Startup))]
namespace Sample.AzureFunctions.DotNet31
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.WithProperty("Application", "Sample.AzureFunctions.DotNet31")
                .Enrich.FromLogContext()
                .CreateLogger();

            builder.Services.AddSingleton<ILoggerProvider>(sp => new SerilogLoggerProvider(Log.Logger, true));

            builder.Services.AddLogging(lb => lb.AddSerilog(Log.Logger, true));
        }
    }
}
