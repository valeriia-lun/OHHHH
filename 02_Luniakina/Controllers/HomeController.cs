using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _02_Luniakina.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _02_Luniakina.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }


        [HttpPost]
        public ViewResult Index(Person person)
        {
            /* Person _person = new Person(
                 HttpContext.Request.Form["Name"],
                  HttpContext.Request.Form["LastName"],
                  DateTime.ParseExact(HttpContext.Request.Form["BirthDate"], "dd-MM-yyyy", null),
                    HttpContext.Request.Form["EMail"]
                 ) ;*/
            return View("Age", person);
        }







    }
}