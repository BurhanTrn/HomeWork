using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController
        public ActionResult Index()
        {
            var blogYazilari = new List<BlogYazisi>
        {
            new BlogYazisi { Baslik = "Yazı 1", Ozet = "Özet 1", ResimUrl = "https://picsum.photos/200/150?random=1" },
            new BlogYazisi { Baslik = "Yazı 2", Ozet = "Özet 2", ResimUrl = "https://picsum.photos/200/150?random=2" },
            new BlogYazisi { Baslik = "Yazı 3", Ozet = "Özet 3", ResimUrl = "https://picsum.photos/200/150?random=3" },
            new BlogYazisi { Baslik = "Yazı 4", Ozet = "Özet 4", ResimUrl = "https://picsum.photos/200/150?random=4" },
            new BlogYazisi { Baslik = "Yazı 5", Ozet = "Özet 5", ResimUrl = "https://picsum.photos/200/150?random=5" },
            new BlogYazisi { Baslik = "Yazı 6", Ozet = "Özet 6", ResimUrl = "https://picsum.photos/200/150?random=6" },
            new BlogYazisi { Baslik = "Yazı 7", Ozet = "Özet 7", ResimUrl = "https://picsum.photos/200/150?random=7" },
            new BlogYazisi { Baslik = "Yazı 8", Ozet = "Özet 8", ResimUrl = "https://picsum.photos/200/150?random=8" },
            new BlogYazisi { Baslik = "Yazı 9", Ozet = "Özet 9", ResimUrl = "https://picsum.photos/200/150?random=9" },
            new BlogYazisi { Baslik = "Yazı 10", Ozet = "Özet 10", ResimUrl = "https://picsum.photos/200/150?random=10" }
        };
            return View(blogYazilari);
        }

    }
}









