using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AspFood.Controllers
{
    public class SpecialController : Controller
    {
        private readonly IMenu _menu;

        public SpecialController(IMenu menu)
        {
            _menu = menu;
        }

        public IActionResult Index()
        {
            var values = _menu.GetCategoryInclude().Where(x=>x.CategoryName=="Burgerlər");
            return View(values);
        }
    }
}
