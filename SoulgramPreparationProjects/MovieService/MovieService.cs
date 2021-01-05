using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieService
{
    public class MovieService
    {
        private readonly HttpClient _httpClient;

        public MovieService()
        {
            //services.AddHttpClient<MovieService>(c =>
            //{
            //    c.BaseAddress = new Uri(Settings.RapidImdbHost),
            //    c.DefaultRequestHeaders.Add("x-rapidapi-key", Settings.RapidApiKey),
            //    c.DefaultRequestHeaders.Add("x-rapidapi-host", Settings.RapidImdbHost)
            //});

            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri($"https://{Settings.RapidImdbHost}"),
            };

            _httpClient.DefaultRequestHeaders.Add("x-rapidapi-key", Settings.RapidApiCloudTestKey);
            _httpClient.DefaultRequestHeaders.Add("x-rapidapi-host", Settings.RapidImdbHost);
        }

        // Games, Tv Series, Tv Movies
        public async Task GetAutocompleteMovies(string title)
        {
            var url = $"{MoviesUrl.AutoCompleteByTitle}{Uri.EscapeDataString(title)}";
            var response = await _httpClient.GetAsync(url);

            //TODO Create model for database entity
            var result = await HttpResponseParser.ParseJson<ImdbAutocompleteResponse>(response);

            await Task.CompletedTask;
        }
    }
}
