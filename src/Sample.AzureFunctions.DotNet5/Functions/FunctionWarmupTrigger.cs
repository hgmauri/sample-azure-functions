﻿using Microsoft.Azure.Functions.Worker.Pipeline;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet5.Functions
{
    public static class FunctionWarmupTrigger
    {
        [FunctionName(nameof(FunctionWarmupTrigger))]
        public static void Run([WarmupTrigger] FunctionExecutionContext context)
        {
            var logger = context.Logger;

            logger.LogInformation("Function App instance is now warm!");
        }
    }
}
