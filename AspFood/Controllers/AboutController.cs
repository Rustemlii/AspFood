using Microsoft.AspNetCore.Mvc;

namespace AspFood.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
