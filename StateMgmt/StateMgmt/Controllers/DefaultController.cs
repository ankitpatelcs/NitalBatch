using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateMgmt.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Cookiess()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cookiess(FormCollection fc)
        {
            string uname = fc["txtun"];
            string pass = fc["txtps"];

            if (uname == "nital" && pass == "n123")
            {
                HttpCookie couname = new HttpCookie("uname");
                couname.Value = uname;
                couname.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(couname);

                HttpCookie copass = new HttpCookie("pass");
                copass.Value = pass;
                copass.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(copass);
            }

            return View();
        }
        public ActionResult Qstring(int id,string name)
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string uname = fc["txtun"];
            string pass = fc["txtps"];

            if (uname=="dharmesh" && pass=="123")
            {
                Session["uname"] = uname;
                Session["pass"] = pass;
                Session.Timeout = 30;
                return RedirectToAction("HomePage");
            }
            else
            {
                ViewBag.loginerror = "Invalid Username or password.!";
            }

            return View();
        }
        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }

        public ActionResult svar()
        {
            ViewBag.data = "message from ViewBag";
            ViewData["msg"] = "displaying data from ViewData";

            TempData["info"] = "displaying TempData value";

            return View();
        }

        public ActionResult second()
        {
            return View();
        }
    }
}