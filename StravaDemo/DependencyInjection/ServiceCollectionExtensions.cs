using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using StravaDemo.StravaClients.Activities;
using StravaDemo.StravaClients.Upload;
using StravaDemo.Utility;

namespace StravaDemo.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddTacxDemoApi(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(typeof(Startup));
            serviceCollection.AddControllers();
        }

        public static void AddStravaClient(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ActivitiesClient>();
            serviceCollection.AddTransient<UploadClient>();
            serviceCollection.AddTransient<TokenRefresher>();
            serviceCollection.AddTransient<RestClientFactory>();
            serviceCollection.AddScoped(provider => ((RestClientFactory)provider.GetService(typeof(RestClientFactory))).GetClient());
        }
    }
}
