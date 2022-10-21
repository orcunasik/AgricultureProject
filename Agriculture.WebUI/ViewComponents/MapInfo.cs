using Agriculture.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.ViewComponents
{
    public class MapInfo : ViewComponent
    {
        private readonly IAddressService _addressService;

        public MapInfo(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IViewComponentResult Invoke(int id=1)
        {
            var result = _addressService.GetById(id);
            return View(result);
        }
    }
}
