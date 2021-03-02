using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet31.Functions
{
    public static class FunctionQueue
    {
        [FunctionName(nameof(FunctionQueue))]
        public static void Run([QueueTrigger("queue-test", Connection = "AzureWebJobsStorage")] Book myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            try
            {
                var value = Convert.ToInt32("test");
            }
            catch (Exception ex)
            {
                log.LogError(ex, "error");
                throw;
            }
        }
    }

    public class Book
    {
        public string Name { get; set; }

        public string Id { get; set; }
    }
}
