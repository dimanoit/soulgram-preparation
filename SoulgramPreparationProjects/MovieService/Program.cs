using System;
using System.Threading.Tasks;

namespace MovieService
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            var movieService = new MovieService();
            var kinpMovieService = new KinopoiskMovieService();

            await kinpMovieService.GetMovie(1143242); //Movie "Джентельмены"

            //await kinpMovieService.GetAllMovie(1);
            //await movieService.GetAutocompleteMovies("Мальчишник");
        }
    }
}
