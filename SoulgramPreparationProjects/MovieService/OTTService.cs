using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieService
{
    public class OTTService
    {
        private readonly HttpClient _httpClient;

        public OTTService()
        {
            //services.AddHttpClient<MovieService>(c =>
            //{
            //    c.BaseAddress = new Uri(Settings.RapidImdbHost),
            //    c.DefaultRequestHeaders.Add("x-rapidapi-key", Settings.RapidApiKey),
            //    c.DefaultRequestHeaders.Add("x-rapidapi-host", Settings.RapidImdbHost)
            //});

            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri($"https://ott-details.p.rapidapi.com"),
            };

            _httpClient.DefaultRequestHeaders.Add("x-rapidapi-key", "eba3f8d4f1mshbd156accbfdadafp125a1ajsnf1aec3e5efe3");
            _httpClient.DefaultRequestHeaders.Add("x-rapidapi-host", "ott-details.p.rapidapi.com");
        }

        // Games, Tv Series, Tv Movies
        public async Task GetAutocompleteMovies(string title)
        {
            var kek = Uri.EscapeDataString(title);
            var url = $"/search?title={kek}&page=1";
            var response = await _httpClient.GetAsync(url);

            //TODO Create model for database entity
            var result = await response.Content.ReadAsStringAsync();

            await Task.CompletedTask;
        }
    }
}

