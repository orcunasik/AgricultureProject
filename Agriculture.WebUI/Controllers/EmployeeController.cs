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
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        EmployeeValidator employeeValidator = new();

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
            ValidationResult result = employeeValidator.Validate(employee);
            if (result.IsValid)
            {
                _employeeService.Insert(employee);
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
        public IActionResult UpdateEmployee(int id)
        {
            var result = _employeeService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            ValidationResult result = employeeValidator.Validate(employee);
            if (result.IsValid)
            {
                _employeeService.Update(employee);
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
        public IActionResult DeleteEmployee(int id)
        {
            var result = _employeeService.GetById(id);
            _employeeService.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
