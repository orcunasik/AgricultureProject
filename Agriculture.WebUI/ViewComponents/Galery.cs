using Agriculture.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.ViewComponents
{
    public class Galery : ViewComponent
    {
        private readonly IImageService _imageService;

        public Galery(IImageService imageService)
        {
            _imageService = imageService;
        }
        public IViewComponentResult Invoke()
        {
            var result = _imageService.GetListAll();
            return View(result);
        }
    }
}
