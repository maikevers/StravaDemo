using System;
using NUnit.Framework;
using RestSharp;
using StravaDemo.StravaClients.Upload;
using StravaDemoTests.Unit.DependencyInjection;

namespace StravaDemoTests.Unit.StravaClients
{
    public class TestUploadClient
    {
        private readonly UploadClient _uploadClient;

        private readonly UploadStatusDto _expectedDtoReturned = new UploadStatusDto();

        public TestUploadClient()
        {
            IRestClient restClient = RestClientMockFactory.Get(_expectedDtoReturned);
            TestServiceProvider serviceProvider = new TestServiceProvider(restClient);
            _uploadClient = serviceProvider.Get<UploadClient>();
        }

        [Test]
        public void TestThatUploadClientReturnsExpectedDto()
        {
            ActivityUploadDto activitiesUploadDto = GetTestActivitiesUploadDto();
            UploadStatusDto uploadStatus = _uploadClient.UploadFile(activitiesUploadDto);
            Assert.AreEqual(_expectedDtoReturned, uploadStatus);
        }

        private static ActivityUploadDto GetTestActivitiesUploadDto()
        {
            return new ActivityUploadDto { FilePath = AppDomain.CurrentDomain.BaseDirectory + @"TestFiles\TestGpxFile.tcx" };
        }
    }
}
