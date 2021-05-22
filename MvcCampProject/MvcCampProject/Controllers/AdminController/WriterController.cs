using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCampProject.Controllers.AdminController
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        WriterValidator writerValidator = new WriterValidator();
        // GET: Writer
        public ActionResult Index()
        {
            var writerValues = wm.GetList();
            return View(writerValues);
        }
        public ActionResult AddWriter()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddWriter(Writer w)
        {
            ValidationResult results = writerValidator.Validate(w);//using FluentValidation.Results;
            if (results.IsValid)
            {
                wm.WriterAdd(w);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult EditWriter(int id)
        {
            var writerValue = wm.GetById(id);
            return View(writerValue);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer w)
        {
            ValidationResult results = writerValidator.Validate(w);//using FluentValidation.Results;
            if (results.IsValid)
            {
                wm.WriterUpdate(w);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
           
            return View();
        }
    }
}