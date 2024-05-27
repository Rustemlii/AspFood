using BLL.Abstract;
using DTO.DtoEntity;
using Microsoft.AspNetCore.Mvc;

namespace AspFood.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMessage _message;

        public ContactController(IMessage message)
        {
            _message = message;
        }

        public IActionResult Index(MessageDto dto)
        {
            _message.Insert(dto);
            ViewBag.mesaj = "Qeyde edildi...";
            return View();
        }
    }
}
