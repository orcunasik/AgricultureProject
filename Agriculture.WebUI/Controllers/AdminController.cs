using Agriculture.Business.Abstract;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            var result =_adminService.GetListAll();
            return View(result);
        }
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            _adminService.Insert(admin);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAdmin(int id)
        {
            var result = _adminService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateAdmin(Admin admin)
        {
            _adminService.Update(admin);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAdmin(int id)
        {
            var result = _adminService.GetById(id);
            _adminService.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
