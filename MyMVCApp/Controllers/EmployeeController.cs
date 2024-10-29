using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApp.Models;


namespace MyMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.Where(o=>o.DepartmentId== departmentId).ToList();
            return View(employees);
        }


        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
           Employee employee= employeeContext.Employees.Single(emp => emp.EmployeeId == id);
            return View(employee);
        }
    }
}