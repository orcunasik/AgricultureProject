using Agriculture.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.ViewComponents
{
    public class Address : ViewComponent
    {
        private readonly IAddressService _addressService;

        public Address(IAddressService addressService)
        {
            _addressService = addressService;
        }
        public IViewComponentResult Invoke()
        {
            var result = _addressService.GetListAll();
            return View(result);
        }
    }
}
