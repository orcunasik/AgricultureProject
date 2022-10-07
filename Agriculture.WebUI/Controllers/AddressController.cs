using Agriculture.Business.Abstract;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.Controllers
{
    public class AddressController : Controller
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IActionResult Index()
        {
            var addressList = _addressService.GetListAll();
            return View(addressList);
        }
        [HttpGet]
        public IActionResult AddAddress()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAddress(Address address)
        {
            _addressService.Insert(address);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAddress(int id)
        {
            var result = _addressService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateAddress(Address address)
        {
            _addressService.Update(address);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAddress(int id)
        {
            var result = _addressService.GetById(id);
            _addressService.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
