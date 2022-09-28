using Agriculture.Business.Abstract;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var imageList = _imageService.GetListAll();
            return View(imageList);
        }
        [HttpGet]
        public IActionResult AddImage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddImage(Image image)
        {
            _imageService.Insert(image);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateImage(int id)
        {
            var result = _imageService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateImage(Image image)
        {
           _imageService.Update(image);
           return RedirectToAction("Index");
        }
        public IActionResult DeleteImage(int id)
        {
            var result = _imageService.GetById(id);
            _imageService.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
