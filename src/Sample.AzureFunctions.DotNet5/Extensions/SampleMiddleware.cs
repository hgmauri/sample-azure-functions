using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker.Pipeline;

namespace Sample.AzureFunctions.DotNet5.Extensions
{
    public class SampleMiddleware
    {
        public Task Invoke(FunctionExecutionContext context, FunctionExecutionDelegate next)
        {
            context.Items.Add("Greeting", "Hello from our middleware");
            return next(context);
        }
    }
}
