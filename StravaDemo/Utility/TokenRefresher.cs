using System.Collections.Specialized;
using System.Web;
using RestSharp;

namespace StravaDemo.Utility
{
    public class TokenRefresher
    {
        private const string ClientId = "Your client id here";

        private const string ClientSecret = "Your secret here";

        private const string GrantType = "refresh_token";

        private const string RefreshToken = "Your refresh token here";

        private const string StravaTokenUri = "https://www.strava.com/oauth/token?";

        public RefreshTokenDto GetNewToken()
        {
            string tokenRequestUri = GetTokenRequestUri();
            RestClient client = new RestClient(tokenRequestUri);
            RestRequest request = new RestRequest(Method.POST);
            IRestResponse<RefreshTokenDto> response = client.Execute<RefreshTokenDto>(request);
            return response.Data;
        }

        private static string GetTokenRequestUri()
        {
            NameValueCollection queryString = HttpUtility.ParseQueryString(string.Empty);

            queryString["client_id"] = ClientId;
            queryString["client_secret"] = ClientSecret;
            queryString["grant_type"] = GrantType;
            queryString["refresh_token"] = RefreshToken;

            string tokenRequest = queryString.ToString();
            string tokenRequestUri = StravaTokenUri + tokenRequest;
            return tokenRequestUri;
        }
    }
}
