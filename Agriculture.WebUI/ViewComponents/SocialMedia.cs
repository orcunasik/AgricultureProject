using Agriculture.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.ViewComponents
{
    public class SocialMedia : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMedia(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _socialMediaService.GetListAll();
            return View(result);
        }
    }
}
