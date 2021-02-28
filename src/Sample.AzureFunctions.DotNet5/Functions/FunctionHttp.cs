using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Pipeline;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet5.Functions
{
    public class FunctionHttp
    {
        [FunctionName(nameof(FunctionHttp))]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequestData req,
            FunctionExecutionContext executionContext)
        {
            var log = executionContext.Logger;

            log.LogInformation("C# HTTP trigger function processed a request.");

            var response = new HttpResponseData(HttpStatusCode.OK, "OK");

            return response;
        }
    }
}
