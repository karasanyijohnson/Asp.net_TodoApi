using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class New : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
