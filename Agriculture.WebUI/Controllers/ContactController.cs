using Agriculture.Business.Abstract;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var contactList = _contactService.GetListAll();
            return View(contactList);
        }
        [HttpGet]
        public IActionResult MessageDetails(int id)
        {
            var result = _contactService.GetById(id);
            return View(result);
        }
        public IActionResult DeleteMessage(int id)
        {
            var result = _contactService.GetById(id);
            _contactService.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
