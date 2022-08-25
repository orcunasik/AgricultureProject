using Agriculture.Business.Abstract;
using Agriculture.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriculture.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employeeList = _employeeService.GetListAll();
            return View(employeeList);
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.Insert(employee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateEmployee(int id)
        {
            var result = _employeeService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.Update(employee);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEmployee(int id)
        {
            var result = _employeeService.GetById(id);
            _employeeService.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
