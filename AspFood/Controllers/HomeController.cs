using BLL.Abstract;
using BLL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AspFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMenu _menuservice;

        public HomeController(IMenu menuservice)
        {
            _menuservice = menuservice;
        }

        public IActionResult Index()
        {
            var values=_menuservice.GetCategoryInclude();
            ViewBag.c = _menuservice.GetCategoryInclude().Where(x => x.CategoryName == "Pizzalar");
            return View(values);
        }


    }
}
