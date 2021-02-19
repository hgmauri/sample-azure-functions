using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sample.AzureFunctions.DotNet5.Extensions;

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
                .ConfigureFunctionsWorker((hostBuilderContext, workerApplicationBuilder) =>
                {
                    workerApplicationBuilder.UseSampleMiddleware();
                    workerApplicationBuilder.UseFunctionExecutionMiddleware();
                })
                .ConfigureServices(services =>
                {
                    services.AddLogging();
                })
                .Build();

            return host.RunAsync();
        }
    }
}
