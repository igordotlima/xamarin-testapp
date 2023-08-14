using System.Net.Http;

namespace TestApp.Network
{
    interface IRestService
    {
        HttpClient GetClient();
    }
}
