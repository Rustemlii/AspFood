using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AspFood.Controllers
{

    public class SearchController : Controller
    {
        private readonly IMenu _menu;

        public SearchController(IMenu menu)
        {
            _menu = menu;
        }

        public IActionResult Index(string search)
        {
            var values = from x in _menu.GetCategoryInclude() select x;
            if (!string.IsNullOrEmpty(search))
            {
                values = values.Where(x => x.Title.ToLower().Contains(search.ToLower()));
            }
            return View(values);
          
        }
    }
}
