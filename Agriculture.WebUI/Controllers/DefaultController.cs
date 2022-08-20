using Agriculture.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IServiceService _serviceService;

        public DefaultController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var result = _serviceService.GetListAll();
            return View(result);
        }
    }
}
