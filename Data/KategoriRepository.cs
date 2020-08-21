using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class KategoriRepository
    {
        private static List<Kategori> _categories = null;

        static KategoriRepository()
        {
            _categories = new List<Kategori>()
            {
new Kategori(){Id=1,Name="Macera"},
new Kategori(){Id=2,Name="Romantik"},
new Kategori(){Id=3,Name="Bilim kurgu"},
new Kategori(){Id=4,Name="Savaş"},
new Kategori(){Id=5,Name="Komedi"},

            };
        }
        public static List<Kategori> categories
        {
            get
            {
                return _categories;
            }
        }
        public static void AddKategori(Kategori entity)
        {
            _categories.Add(entity);
        }
        public static Kategori GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }

}