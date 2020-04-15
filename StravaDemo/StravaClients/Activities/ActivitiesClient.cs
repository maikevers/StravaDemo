using System.Collections.Generic;
using RestSharp;

namespace StravaDemo.StravaClients.Activities
{
    public class ActivitiesClient
    {
        private const string BaseActivitiesUrl = "https://www.strava.com/api/v3/activities";

        private readonly IRestClient _restClient;

        public ActivitiesClient(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public List<ActivityDto> GetActivities()
        {
            IRestRequest request = new RestRequest(BaseActivitiesUrl, Method.GET);
            IRestResponse<List<ActivityDto>> response = _restClient.Execute<List<ActivityDto>>(request);
            return response.Data;
        }
    }
}
