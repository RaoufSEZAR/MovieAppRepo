using System.Collections.Generic;

namespace MovieApp.Models
{
    public class MovieKategoriModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Kategori> categories { get; set; }
        public IEnumerable<Movie> movies { get; set; }
    }
}