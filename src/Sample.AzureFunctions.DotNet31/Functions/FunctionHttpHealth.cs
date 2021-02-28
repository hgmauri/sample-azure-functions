using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet31.Functions
{
    public class FunctionHttpHealthCheck
    {
        [FunctionName(nameof(FunctionHttpHealthCheck))]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "health")] HttpRequest req, ILogger log)
        {
            //check dependencies 

            return new OkObjectResult("ok");
        }
    }
}
