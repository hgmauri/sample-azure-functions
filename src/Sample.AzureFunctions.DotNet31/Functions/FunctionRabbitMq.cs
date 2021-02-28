using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet31.Functions
{
    public static class FunctionRabbitMq
    {
        [FunctionName(nameof(FunctionRabbitMq))]
        public static void Run([RabbitMQTrigger(queueName: "hello", ConnectionStringSetting = "RabbitmqConnection")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
