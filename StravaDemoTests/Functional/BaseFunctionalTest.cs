using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using StravaDemo;

namespace StravaDemoTests.Functional
{
    public abstract class BaseFunctionalTest
    {
        protected readonly TestServer TestServer;

        public BaseFunctionalTest()
        {
            IWebHostBuilder builder = new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>();

            TestServer = new TestServer(builder);
        }
    }
}
