using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        List<BlogModel> blogModels;

        public BlogController()
        {
            blogModels = [
                new BlogModel {
                     Title = "Başlık1", Özetİfade ="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Görsel = "https://picsum.photos/id/151/200/300"
                }, new BlogModel {
                     Title = "Başlık2", Özetİfade ="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Görsel = "https://picsum.photos/id/83/200/300"
                }, new BlogModel {
                     Title = "Başlık3", Özetİfade ="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Görsel = "https://picsum.photos/id/95/200/300"
                }, new BlogModel {
                     Title = "Başlık4", Özetİfade ="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Görsel = "https://picsum.photos/id/102/200/300"
                }, new BlogModel {
                     Title = "Başlık5", Özetİfade ="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Görsel = "https://picsum.photos/id/158/200/300"
                }, new BlogModel {
                     Title = "Başlık6", Özetİfade ="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Görsel = "https://picsum.photos/id/111/200/300"
                }, new BlogModel {
                     Title = "Başlık7", Özetİfade ="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Görsel = "https://picsum.photos/id/114/200/300"
                }, new BlogModel {
                     Title = "Başlık8", Özetİfade ="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Görsel = "https://picsum.photos/id/123/200/300"
                }, new BlogModel {
                     Title = "Başlık9", Özetİfade ="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Görsel = "https://picsum.photos/id/196/200/300"
                }, new BlogModel {
                     Title = "Başlık10", Özetİfade ="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.", Görsel = "https://picsum.photos/id/191/200/300"
                }
            ];
        }
        public ActionResult Index()
        {
            ViewBag.blogList=blogModels;
            return View();
        }


    }
}
