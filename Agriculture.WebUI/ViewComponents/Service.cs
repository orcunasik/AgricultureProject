using Agriculture.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.ViewComponents
{
    public class Service : ViewComponent
    {
        private readonly IServiceService _serviceService;

        public Service(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _serviceService.GetListAll();
            return View(result);
        }
    }
}
