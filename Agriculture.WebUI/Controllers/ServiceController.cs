using Agriculture.Business.Abstract;
using Agriculture.Entities.Concrete;
using Agriculture.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var serviceList = _serviceService.GetListAll();
            return View(serviceList);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }
        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel serviceAddViewModel)
        {
            if (ModelState.IsValid)
            {
                _serviceService.Insert(new Service()
                {
                    Title = serviceAddViewModel.Title,
                    Description = serviceAddViewModel.Description,
                    ImageUrl = serviceAddViewModel.ImageUrl
                });
                return RedirectToAction("Index");
            }
            return View(serviceAddViewModel);
        }
        public IActionResult DeleteService(int id)
        {
            var result = _serviceService.GetById(id);
            _serviceService.Delete(result);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var result = _serviceService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.Update(service);
            return RedirectToAction("Index");
        }
    }
}
