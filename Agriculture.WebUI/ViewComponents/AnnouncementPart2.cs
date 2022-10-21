using Agriculture.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.ViewComponents
{
    public class AnnouncementPart2 : ViewComponent
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementPart2(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }
        public IViewComponentResult Invoke(int id = 2)
        {
            var result = _announcementService.GetById(id);
            return View(result);
        }
    }
}
