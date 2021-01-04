using System;
using System.Threading.Tasks;

namespace MovieService
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var movieService = new MovieService();

            await movieService.GetAutocompleteMovies("Мальчишник");
        }
    }
}
