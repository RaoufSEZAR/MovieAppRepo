using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data {
    public static class MovieRepository {
        private static List<Movie> _movies = null;
        static MovieRepository () {
            _movies = new List<Movie> () {
                new Movie () {
                Id = 1,
                Name = "Shazam",
                Description = "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam adipisci fugiat est. Culpa,ipsam cumque soluta molestiae doloremque possimus ratione dolores nesciunt fugit quidem magnam! Et vitae</p><p>sit,odit aliquam velit tempora numquam vel ipsam officia, reiciendis laborum veritatis exercitationem!</p>",
                ShortDesc = "Shazam",
                ImageUrl = "1.jpg", CategoriId = 1
                },

                new Movie () {
                Id = 2,
                Name = "Amazing Grace",
                Description = "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam adipisci fugiat est. Culpa,ipsam cumque soluta molestiae doloremque possimus ratione dolores nesciunt fugit quidem magnam! Et vitae</p><p>sit,odit aliquam velit tempora numquam vel ipsam officia, reiciendis laborum veritatis exercitationem!</p>",
                ShortDesc = "Amazing Grace", ImageUrl = "2.jpg", CategoriId = 1
                },

                new Movie () {
                Id = 3,
                Name = "High Life",
                Description = "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam adipisci fugiat est. Culpa,ipsam cumque soluta molestiae doloremque possimus ratione dolores nesciunt fugit quidem magnam! Et vitae</p><p>sit,odit aliquam velit tempora numquam vel ipsam officia, reiciendis laborum veritatis exercitationem!</p>",
                ShortDesc = "High Life", ImageUrl = "3.jpg", CategoriId = 2
                },

                new Movie () {
                Id = 4, Name = "Billboard",
                Description = "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam adipisci fugiat est. Culpa,ipsam cumque soluta molestiae doloremque possimus ratione dolores nesciunt fugit quidem magnam! Et vitae</p><p>sit,odit aliquam velit tempora numquam vel ipsam officia, reiciendis laborum veritatis exercitationem!</p>",
                ShortDesc = "Billboard", ImageUrl = "4.jpg", CategoriId = 3
                },

                new Movie () {
                Id = 5,
                Name = "Storm Boy",
                Description = "<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Veniam adipisci fugiat est. Culpa,ipsam cumque soluta molestiae doloremque possimus ratione dolores nesciunt fugit quidem magnam! Et vitae</p><p>sit,odit aliquam velit tempora numquam vel ipsam officia, reiciendis laborum veritatis exercitationem!</p>",
                ShortDesc = "Storm Boy",
                ImageUrl = "5.jpg", CategoriId = 2
                },
            };
        }
        public static List<Movie> movies {
            get {
                return _movies;
            }
        }
        public static void AddMovie (Movie entity) {
            _movies.Add (entity);
        }
        public static Movie GetById (int id) {
            return _movies.FirstOrDefault (i => i.Id == id);
        }
    }

}