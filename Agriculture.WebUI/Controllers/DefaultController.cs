using Agriculture.Business.Abstract;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IContactService _contactService;

        public DefaultController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult _SendMessage(Contact contact)
        {
            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            _contactService.Insert(contact);
            return RedirectToAction("Index");
        }
        public PartialViewResult _ScriptPartial()
        {
            return PartialView();
        }
    }
}
