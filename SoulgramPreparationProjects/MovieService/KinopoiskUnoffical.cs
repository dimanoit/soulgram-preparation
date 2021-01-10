using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieService
{
    public class KinopoiskUnoffical
    {
        private readonly HttpClient _httpClient;

        public KinopoiskUnoffical()
        {
            //services.AddHttpClient<MovieService>(c =>
            //{
            //    c.BaseAddress = new Uri(Settings.RapidImdbHost),
            //    c.DefaultRequestHeaders.Add("x-rapidapi-key", Settings.RapidApiKey),
            //    c.DefaultRequestHeaders.Add("x-rapidapi-host", Settings.RapidImdbHost)
            //});

            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://kinopoiskapiunofficial.tech"),
            };

            _httpClient.DefaultRequestHeaders.Add("X-API-KEY", "37d50b69-b8b1-4ad1-a9a9-43c966958375");
        }

        public async Task GetMovie(string filmTitle)
        {
            var encapsulatedData = Uri.EscapeDataString(filmTitle);
            var url = $"/api/v2.1/films/search-by-keyword?keyword={encapsulatedData}&page=1";
            var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseContentRead);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Kek chebyrek");
            }

            var result = await response.Content.ReadAsStringAsync();
            result = filmTitle;
        }

    }
}
