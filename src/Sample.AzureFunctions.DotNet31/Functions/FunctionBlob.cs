using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet31.Functions
{
    public static class FunctionBlob
    {
        [FunctionName(nameof(FunctionBlob))]
        public static void Run(
            [BlobTrigger("demo/{name}", Connection = "AzureWebJobsStorage")] Stream myBlob,
            [Blob("output/{name}", FileAccess.Write, Connection = "AzureWebJobsStorage")] Stream outputBlob,
            string name, ILogger log)
        {
            log.LogInformation($"CC Blob Trigger function executed at: {DateTime.Now}");

            myBlob.CopyTo(outputBlob);

        }
    }
}