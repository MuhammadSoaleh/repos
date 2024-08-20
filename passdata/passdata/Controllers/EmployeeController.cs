using Microsoft.AspNetCore.Mvc;
using passdata.Models;
using System.Linq.Expressions;

namespace passdata.Controllers

{
    public class EmployeeController : Controller
    {
       

        public IActionResult Index()
        {

            employee emp = new employee
            {
                Id = 1,
                name = "soaleh",
                age = 30,
                city = "khi"
            };
            ViewBag.empl = emp;
            employee emp1 = new employee
            {
                Id = 2,
                name = "khizer",
                age = 30,
                city = "khi"
            };
            ViewBag.empl1 = emp1;

            return View();
        }
    }
}
