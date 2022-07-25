using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorControls.EDM;

namespace RazorControls.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(dc.tblemployees.ToList());
        }

        void fillcity()
        {
            var citydata = from c in dc.tblcities
                           select new SelectListItem
                           {
                               Text = c.city_name,
                               Value = c.city_id.ToString()
                           };
            ViewBag.cities = citydata.ToList();
        }
        public ActionResult Create()
        {
            fillcity();
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblemployee obj, FormCollection fc, HttpPostedFileBase file)
        {
            bool Reading = Convert.ToBoolean(fc["Reading"].Split(',')[0]);
            bool Playing = Convert.ToBoolean(fc["Playing"].Split(',')[0]);
            bool Listening = Convert.ToBoolean(fc["Listening"].Split(',')[0]);
            string hoby = "";
            if (Reading)
            {
                hoby += "Reading,";
            }
            if (Playing)
            {
                hoby += "Playing,";
            }
            if (Listening)
            {
                hoby += "Listening,";
            }
            obj.hobbies = hoby;

            if (file!=null)
            {
                string filename = Path.GetFileName(file.FileName);
                string fullpath = Path.Combine(Server.MapPath("~/Docs"),filename);
                file.SaveAs(fullpath);
                obj.profileimg = filename;
            }

            dc.tblemployees.Add(obj);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}