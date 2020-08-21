using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;

namespace MovieApp.ViewComponents {
    public class CategoriMenuViewComponent : ViewComponent {

        public IViewComponentResult Invoke () {
            //بقلب صفحة الأساسية ان عملت فلترة يختار الاسامي المفلترة بس من 
            //هل الاسامي ان اخترت اسم مايضل مشغل كلاس الاكتيف على الفلترة
            if (RouteData.Values["action"].ToString () == "Index")
                ViewBag.SelectedCategori = RouteData?.Values["id"];
            return View (KategoriRepository.categories);
        }
    }
}