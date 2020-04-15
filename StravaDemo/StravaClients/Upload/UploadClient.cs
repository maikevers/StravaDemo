using RestSharp;

namespace StravaDemo.StravaClients.Upload
{
    public class UploadClient
    {
        private const string BaseUploadUrl = "https://www.strava.com/api/v3/uploads/";

        private readonly IRestClient _restClient;

        public UploadClient(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public UploadStatusDto UploadFile(ActivityUploadDto activityUploadDto)
        {
            RestRequest request = new RestRequest(BaseUploadUrl, Method.POST);
            request.AddFile("FilePath", activityUploadDto.FilePath, "application/xml");
            
            request.AddParameter("DataType", activityUploadDto.DataType);
            request.AddParameter("ActivityType", activityUploadDto.ActivityType);
            request.AddParameter("private", activityUploadDto.IsPrivate? 1 : 0);
            request.AddParameter("commute", activityUploadDto.IsCommute? 1 : 0);

            IRestResponse<UploadStatusDto> response = _restClient.Execute<UploadStatusDto>(request);
            return response.Data;
        }
    }
}
