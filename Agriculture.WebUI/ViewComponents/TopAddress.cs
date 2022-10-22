using Agriculture.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.ViewComponents
{
    public class TopAddress : ViewComponent
    {
        private readonly IAddressService _addressService;

        public TopAddress(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IViewComponentResult Invoke()
        {
            var result =_addressService.GetListAll();
            return View(result);
        }
    }
}
