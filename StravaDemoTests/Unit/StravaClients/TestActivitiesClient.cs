using System.Collections.Generic;
using NUnit.Framework;
using RestSharp;
using StravaDemo.StravaClients.Activities;
using StravaDemoTests.Unit.DependencyInjection;

namespace StravaDemoTests.Unit.StravaClients
{
    [TestFixture]
    public class TestActivitiesClient
    {
        private readonly ActivitiesClient _activitiesClient;

        private readonly List<ActivityDto> _expectedDtoReturned = new List<ActivityDto>();

        public TestActivitiesClient()
        {
            IRestClient restClient = RestClientMockFactory.Get(_expectedDtoReturned);
            TestServiceProvider serviceProvider = new TestServiceProvider(restClient);
            _activitiesClient = serviceProvider.Get<ActivitiesClient>();
        }

        [Test]
        public void TestThatActivitiesClientReturnsExpectedDto()
        {
            List<ActivityDto> activities = _activitiesClient.GetActivities();
            Assert.AreEqual(_expectedDtoReturned, activities);
        }
    }
}
