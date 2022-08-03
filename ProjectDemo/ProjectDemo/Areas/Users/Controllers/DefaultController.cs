using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectDemo.EDM;

namespace ProjectDemo.Areas.Users.Controllers
{
    public class DefaultController : Controller
    {
        ecommerceEntities dc = new ecommerceEntities();
        // GET: Users/Default
        public ActionResult HomePage()
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
            string email = fc["email"];
            string pass = fc["password"];

            var obj = dc.tblUsers.Where(u => u.email == email && u.password == pass).FirstOrDefault();
            if (obj != null)
            {
                Session["UserId"] = obj.user_id;
                Session["UserName"] = obj.f_name;
                return RedirectToAction("HomePage");
            }
            else
            {
                ViewBag.loginerror = "Invalid Email or Password.!";
            }

            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("HomePage");
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View(dc.tblproducts.ToList());
        }
        public ActionResult Single(int id)
        {
            return View(dc.tblproducts.Find(id));
        }

        public string AddToCart(int id)
        {
            int userid = Convert.ToInt32(Session["UserId"]);
            tblcart obj = new tblcart();
            obj.product_id = id;
            obj.qty = 1;
            obj.user_id = userid;

            dc.tblcarts.Add(obj);
            dc.SaveChanges();
            return "Product added to Cart.";
        }
    }
}