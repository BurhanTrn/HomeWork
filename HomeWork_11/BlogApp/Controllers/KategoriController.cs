using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class KategoriController : Controller
    {
        // GET: KategoriController
        public ActionResult Index()
        {
            ViewBag.Kategoriler = new List<Kategori>
            {
                new Kategori { Id =1, Ad ="Kategori 1" },
                new Kategori {Id =2, Ad ="Kategori 2"},
                new Kategori {Id=3, Ad="Kategori 3"}
            };

            return View();
        }

    }
}
