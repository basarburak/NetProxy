using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace NetProxy.Api.Contract.Extensions
{
    public static class JsonExtensions
    {
        public async static Task<T> ResponseMessageToMap<T>(this HttpResponseMessage httpResponseMessage) where T : class
        {
            return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
        }
    }
}
