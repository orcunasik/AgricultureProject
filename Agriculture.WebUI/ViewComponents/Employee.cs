using Agriculture.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.ViewComponents
{
    public class Employee : ViewComponent
    {
        private readonly IEmployeeService _employeeService;

        public Employee(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _employeeService.GetListAll();
            return View(result);
        }
    }
}
