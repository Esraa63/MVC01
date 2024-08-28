using Microsoft.AspNetCore.Mvc;

namespace MVC01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult  Index()
        {

            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = "hello from content result";
            //return contentResult;
            //return Content("hello from content");
            return View();
        }
        public IActionResult AboutUs()
        {
            return View(); 
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
