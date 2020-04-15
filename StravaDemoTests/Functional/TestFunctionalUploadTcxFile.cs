using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using NUnit.Framework;
using StravaDemo.StravaClients.Upload;

namespace StravaDemoTests.Functional
{
    [TestFixture]
    public class TestFunctionalUploadTcxFile : BaseFunctionalTest
    {
        [Test]
        public void TestIntegrationOfUploadingTcxFileReturnsSuccess()
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:44392/UploadTcx");
            request.Content = new StringContent(GetTestUploadActivityDtoAsJson());
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpClient client = TestServer.CreateClient();
            HttpResponseMessage result = client.SendAsync(request).GetAwaiter().GetResult();
            Assert.True(result.IsSuccessStatusCode);
        }

        private static string GetTestUploadActivityDtoAsJson()
        {
            return JsonSerializer.Serialize(GetTestActivityUploadDto());
        }

        private static ActivityUploadDto GetTestActivityUploadDto()
        {
            return new ActivityUploadDto
            {
                ActivityType = "walk",

                Name = "Test Walk",

                Description = "Test Description",

                TrainerId = 0,

                DataType = "tcx",

                ExternalId = 1,

                FilePath = AppDomain.CurrentDomain.BaseDirectory + @"TestFiles\TestGpxFile.tcx",

                IsPrivate = true,

                IsCommute = false
            };
        }
    }
}
