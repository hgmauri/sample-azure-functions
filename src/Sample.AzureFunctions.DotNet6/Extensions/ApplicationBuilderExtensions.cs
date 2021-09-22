using Microsoft.Extensions.DependencyInjection;

namespace Sample.AzureFunctions.DotNet6.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IServiceCollection UseSampleMiddleware(this IServiceCollection builder)
        {
            //DI

            return builder;
        }
    }
}
