using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet31.Functions
{
    public static class FunctionHttp
    {
        [FunctionName(nameof(FunctionHttp))]
        public static async Task Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "contract/{id}")]
            HttpRequestMessage req,
            string id,
            ILogger log)
        {
            log.LogInformation($"Function HttpTrigger contract [{id}]");
        }
    }
}