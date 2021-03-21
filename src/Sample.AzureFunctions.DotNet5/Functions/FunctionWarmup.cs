using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet5.Functions
{
    //Premium plan
    public static class FunctionWarmup
    {
        [FunctionName(nameof(FunctionWarmup))]
        public static void Run([WarmupTrigger] FunctionContext context)
        {
            var logger = context.GetLogger(nameof(FunctionWarmup));

            logger.LogInformation("Function App instance is now warm!");
        }
    }
}
