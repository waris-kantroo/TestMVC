using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Repository;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
       private readonly IProductRepository repository;

        public HomeController(IProductRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll();  /// using dependency here
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MVCDemo()
        {
            ViewBag.Message = "Your Demo page.";

            EmployeeData employeeData = new EmployeeData();
            var employeeList = employeeData.GetEmployees();

            return View(employeeList);
        }

        public ActionResult EditMe(string userId)
        {
            EmployeeData employeeData = new EmployeeData();
            var employee = employeeData.GetEmployees().FirstOrDefault(i => i.Id == int.Parse(userId));
             return PartialView("_MyParialView", employee);

          

        }
    }
}