using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCampProject.Controllers.AdminController
{
    public class StatisticsController : Controller
    {
        Context im = new Context();
        // GET: Statistics
        public ActionResult Index()
        {
            ViewBag.resultValue1=im.Categories.Count().ToString();
            ViewBag.resultValue2 = im.Headings.Count(h => h.CategoryId == 11).ToString();

            ViewBag.resultValue3 = im.Writers.Where(w => w.NameSurname.Contains("a") || w.NameSurname.Contains("A")).Count();

            ViewBag.resultValue4 = im.Categories.Where(u => u.CategoryId == im.Headings.GroupBy(x => x.CategoryId).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();

            ViewBag.ResultValue5= im.Categories.Where(c => c.Status == true).Count() -
                          im.Categories.Where(c => c.Status == false).Count();

            return View();
        }
    }
}