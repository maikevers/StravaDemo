using System;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;
using StravaDemo.StravaClients.Activities;
using StravaDemo.StravaClients.Upload;
using StravaDemo.Utility;

namespace StravaDemoTests.Unit.DependencyInjection
{
    public class TestServiceProvider
    {
        private readonly IServiceProvider _serviceProvider;

        public TestServiceProvider(IRestClient restClient)
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<ActivitiesClient>();
            serviceCollection.AddTransient<UploadClient>();
            serviceCollection.AddTransient<TokenRefresher>();
            serviceCollection.AddTransient<RestClientFactory>();
            serviceCollection.AddScoped(provider => restClient);

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        public T Get<T>() where T : class
        {
            return _serviceProvider.GetService(typeof(T)) as T;
        }
    }
}
