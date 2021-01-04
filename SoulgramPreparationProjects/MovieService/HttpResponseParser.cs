using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieService
{
    public static class HttpResponseParser
    {
        public static async Task<T> ParseJson<T>(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException("Received a error response from Cure API");
            }

            var responseJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(responseJson);
        }
    }
}
