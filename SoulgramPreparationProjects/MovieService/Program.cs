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
            var kinpUnOffMovieService = new KinopoiskUnoffical();
            var ottService = new OTTService();


            await ottService.GetAutocompleteMovies("EndGame");
            //await kinpUnOffMovieService.GetMovie("Джентельмены"); //Movie "Джентельмены"
            //await kinpMovieService.GetMovie(1143242); //Movie "Джентельмены"
            //await kinpMovieService.GetAllMovie(1);
            //await movieService.GetAutocompleteMovies("Мальчишник");
        }
    }
}
