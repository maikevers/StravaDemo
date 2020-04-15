using RestSharp;
using RestSharp.Authenticators;

namespace StravaDemo.Utility
{
    public class RestClientFactory
    {
        private readonly TokenRefresher _tokenRefresher;

        public RestClientFactory(TokenRefresher tokenRefresher)
        {
            _tokenRefresher = tokenRefresher;
        }

        public IRestClient GetClient()
        {
            RefreshTokenDto tokenDto = _tokenRefresher.GetNewToken();
            return new RestClient
            {
                Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(tokenDto.access_token, "Bearer")
            };
        }
    }
}
