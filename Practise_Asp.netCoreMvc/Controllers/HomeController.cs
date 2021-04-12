using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practise_Asp.netCoreMvc.Models;
using Practise_Asp.netCoreMvc.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Practise_Asp.netCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IEmployeeRepo _EmplolyeeRepo;

        public HomeController(ILogger<HomeController> logger,IEmployeeRepo EmployeeRepo)
        {
            _logger = logger;

            _EmplolyeeRepo = EmployeeRepo;
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newemployee = _EmplolyeeRepo.Add(employee);
               return RedirectToAction("Index", new { id = newemployee.ID });
            }
            return View();
        }
        public ViewResult Index(int id)
        {
           
            Employee model = _EmplolyeeRepo.GetEmployee(id);
            ViewBag.Employee = model;
            //ViewBag.PageTitle = "Employee Details";

            return View(model);

        }

        public ViewResult Privacy()
        {
            var model = _EmplolyeeRepo.GetAllEmployee();
            return View(model);
        }


        public ViewResult PractiseCss()
        {
            return View();
        }

        public ViewResult CssAnimations()
        {
            return View();
        }

        public ViewResult BoucingBall()
        {
            return View();
        }

        public ViewResult FlippingCard()
        {
            return View();
        }

        public ViewResult TextAnimation()
        {
            return View();
        }



















        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
