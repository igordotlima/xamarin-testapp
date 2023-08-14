using System;
using System.Net.Http;
using TestApp.Network;

namespace TestApp
{
    abstract class BaseRestService : IRestService
    {
        private const string EndpointAddress = "https://dummyjson.com/";
        private readonly HttpClient httpClient;

        public BaseRestService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(EndpointAddress);
        }

        public HttpClient GetClient()
        {
            return httpClient;
        }
    }
}
