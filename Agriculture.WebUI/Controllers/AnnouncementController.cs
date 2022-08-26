using Agriculture.Business.Abstract;
using Agriculture.Business.ValidationRules;
using Agriculture.Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        AnnouncementValidator announcementValidator = new();

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var announcementList = _announcementService.GetListAll();
            return View(announcementList);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            ValidationResult result = announcementValidator.Validate(announcement);
            if (result.IsValid)
            {
                _announcementService.Insert(announcement);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var result = _announcementService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(Announcement announcement)
        {
            ValidationResult result = announcementValidator.Validate(announcement);
            if (result.IsValid)
            {
                _announcementService.Update(announcement);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteAnnouncement(int id)
        {
            var result = _announcementService.GetById(id);
            _announcementService.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
