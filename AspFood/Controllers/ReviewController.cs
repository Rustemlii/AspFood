using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AspFood.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ICustomer _customer;

        public ReviewController(ICustomer customer)
        {
            _customer = customer;
        }

        public IActionResult Index()
        {
            var values = _customer.GetAll();
            return View(values);
        }
    }
}
