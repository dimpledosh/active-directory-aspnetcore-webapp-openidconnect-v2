extern alias BetaLib;
using Graph = BetaLib.Microsoft.Graph;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MSGraph = Microsoft.Graph;

namespace WebApp_OpenIDConnect_DotNet.Services
{
    public class GraphServiceClientFactory
    {
        public static Graph::GraphServiceClient GetAuthenticatedGraphClient(Func<Task<string>> acquireAccessToken, 
                                                                                 string baseUrl)
        {
  
            return new Graph::GraphServiceClient(baseUrl, new CustomAuthenticationProvider(acquireAccessToken));
        }
    }

    class CustomAuthenticationProvider : MSGraph::IAuthenticationProvider
    {
        public CustomAuthenticationProvider(Func<Task<string>> acquireTokenCallback)
        {
            acquireAccessToken = acquireTokenCallback;
        }

        private readonly Func<Task<string>> acquireAccessToken;

        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            string accessToken = await acquireAccessToken.Invoke();

            // Append the access token to the request.
            request.Headers.Authorization = new AuthenticationHeaderValue(
                Infrastructure.Constants.BearerAuthorizationScheme, accessToken);
        }
    }
}
