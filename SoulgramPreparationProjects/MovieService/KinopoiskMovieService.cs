using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieService
{
    public class KinopoiskMovieService
    {
        private readonly HttpClient _httpClient;

        public KinopoiskMovieService()
        {
            //services.AddHttpClient<MovieService>(c =>
            //{
            //    c.BaseAddress = new Uri(Settings.RapidImdbHost),
            //    c.DefaultRequestHeaders.Add("x-rapidapi-key", Settings.RapidApiKey),
            //    c.DefaultRequestHeaders.Add("x-rapidapi-host", Settings.RapidImdbHost)
            //});

            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://api.kinopoisk.cloud"),
            };

        }

        public async Task GetAllMovie(int pageNumber)
        {
            var url = AddToken($"/movies/all/page/{pageNumber}");
            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
        }

        public async Task GetMovie(uint kinopoiskMovieId)
        {
            var url = AddToken($"/movies/{kinopoiskMovieId}");
            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
        }

        private string AddToken(string url) => $"{url}/token/a79810229c8d92ffc0328267481c61c3";
    }
}
