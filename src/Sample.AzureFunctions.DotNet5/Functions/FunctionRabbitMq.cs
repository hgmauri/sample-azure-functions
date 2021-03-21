using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet5.Functions
{
    public static class FunctionRabbitMq
    {
        [FunctionName(nameof(FunctionRabbitMq))]
        [RabbitMQOutput(QueueName = "destinationQueue", ConnectionStringSetting = "RabbitmqConnection")]
        public static string Run([RabbitMQTrigger("queue", ConnectionStringSetting = "RabbitmqConnection")] string item,
            FunctionContext context)
        {
            var logger = context.GetLogger(nameof(FunctionRabbitMq));

            logger.LogInformation(item);

            var message = $"Output message created at {DateTime.Now}";
            return message;
        }
    }
}
