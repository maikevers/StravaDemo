using System.Net.Http;
using NUnit.Framework;

namespace StravaDemoTests.Functional
{
    [TestFixture]
    public class TestFunctionalAverageSpeed : BaseFunctionalTest
    {
        [Test]
        public void TestGetAverageSpeedReturnsSuccess()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:44392/AverageSpeed");
            HttpClient client = TestServer.CreateClient();
            HttpResponseMessage result = client.SendAsync(request).GetAwaiter().GetResult();
            Assert.True(result.IsSuccessStatusCode);
        }
    }
}
