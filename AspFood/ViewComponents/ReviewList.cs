using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AspFood.ViewComponents
{
    public class ReviewList:ViewComponent
    {
        private readonly ICustomer _customer;

        public ReviewList(ICustomer customer)
        {
            _customer = customer;
        }
        public IViewComponentResult Invoke()
        {
            var values = _customer.GetAll();
            return View(values);
        }
    }
}
