﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.ViewComponents
{
    public class Navbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
