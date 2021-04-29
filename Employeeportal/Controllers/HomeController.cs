using BOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employeeportal.Controllers
{
    public class HomeController : Controller
    {
        BALayer.BALayerData systemdata = new BALayer.BALayerData();
        public ActionResult Index()
        {
            return View(systemdata.GetEmployees());
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Employee employee)
        {
            systemdata.InsertEmployee(employee);
            return RedirectToAction("Index");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Employee employee1)
        {
            Employee data = systemdata.GetEmployeeById(employee1.UserId);
            if(employee1.UserId== data.UserId && employee1.Password==data.Password)
            {
                return RedirectToAction("Index");
            }
            return View();

        }

        
    }
}