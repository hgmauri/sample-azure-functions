using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sample.AzureFunctions.DotNet5.Extensions;
using Serilog;
using Serilog.Events;

namespace Sample.AzureFunctions.DotNet5
{
    class Program
    {
        static Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureAppConfiguration(configurationBuilder =>
                {
                    configurationBuilder.AddCommandLine(args);
                })
                .ConfigureFunctionsWorkerDefaults(p =>
                {
                    p.Services.UseSampleMiddleware();
                })
                .ConfigureServices(services =>
                {
                    Log.Logger = new LoggerConfiguration()
                        .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                        .Enrich.WithProperty("Application", "Sample.AzureFunctions.DotNet31")
                        .Enrich.FromLogContext()
                        .CreateLogger();

                    services.AddLogging(lb => lb.AddSerilog(Log.Logger, true));
                })
                .Build();

            return host.RunAsync();
        }
    }
}
