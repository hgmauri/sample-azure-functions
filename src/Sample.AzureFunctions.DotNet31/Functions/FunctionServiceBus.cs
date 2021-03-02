using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet31.Functions
{
    public static class FunctionServiceBus
    {
        [FunctionName(nameof(FunctionServiceBus))]
        public static void Run([ServiceBusTrigger("topic-servicebus", Connection = "AzureServiceBusConnection")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"Dados recebidos via Queue do Azure Service Bus: {myQueueItem}");
        }
    }
}
