using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace MovieDb.Data.Rest
{
    public abstract class BaseRestClient
    {
        private RestClient restClient;
        private readonly string baseUrl;
        private readonly string apiKey;

        public BaseRestClient(IConfiguration configuration)
        {
            this.baseUrl = configuration["MovieDb:BaseUrl"];
            this.apiKey = configuration["MovieDb:ApiKey"];
            restClient = new RestClient(baseUrl);
        }

        protected IRestRequest CreateRequest(string resource,
        Method method = Method.GET,
        bool authenticated = true)
        {
            var request = new RestRequest(resource, method);
            if (authenticated)
            {
                request.AddQueryParameter("api_key", apiKey);
            }

            return request;
        }

        protected async Task<IRestResponse<T>> ExecuteRequestAsync<T>(IRestRequest restRequest)
        where T : new()
        {
            TaskCompletionSource<IRestResponse<T>> taskCompletion = new TaskCompletionSource<IRestResponse<T>>();
            RestRequestAsyncHandle handle = restClient.ExecuteAsync<T>(restRequest, r => taskCompletion.SetResult(r));

            return await taskCompletion.Task;
        }
    }
}