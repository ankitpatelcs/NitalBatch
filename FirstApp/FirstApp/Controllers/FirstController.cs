using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult GetData()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid=1,fname="Nital",mobile="65487" });
            li.Add(new Employee { empid=2,fname="Dharmesh",mobile="65487" });
            li.Add(new Employee { empid=3,fname="Harshita",mobile="65487" });
            return View(li);
        }
    }
}