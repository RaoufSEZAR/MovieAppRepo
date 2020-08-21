using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers {
    public class HomeController : Controller {

        [HttpGet]
        public IActionResult Index (int? id) {
            //ProductRepository.movies; bu sayfada bunlar eklenecek
            //KategoriRepository.categories;

            //ViewComponent kullandigim icin asagdaki kullanmaya gerek kalmadi

            //MovieKategoriModel model = new MovieKategoriModel();
            //model.categories = KategoriRepository.categories;
            //model.movies = MovieRepository.movies;
            //return view(model)
            var movies = MovieRepository.movies;
            if (id != null) {
                movies = movies.Where (i => i.CategoriId == id).ToList ();

            }
            return View (movies);
        }
        public IActionResult Details (int id) {

            //ViewComponent kullandigim icin asagdaki kullanmaya gerek kalmadi

            //MovieKategoriModel model = new MovieKategoriModel ();
            //model.categories = KategoriRepository.categories;
            //model.Movie = MovieRepository.GetById (id);
            //return view(model)
            return View (MovieRepository.GetById (id));
        }

        public IActionResult Contact () {

            return View ();
        }

    }
}