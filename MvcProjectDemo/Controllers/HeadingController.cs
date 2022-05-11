using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectDemo.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingValues = hm.GetList();
            return View(headingValues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Name,
                                                      Value = x.CategoryId.ToString(),
                                                  }).ToList();
            List<SelectListItem> valueWriter = (from x in wm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Name + " " + x.Surname,
                                                      Value = x.WriterId.ToString(),
                                                  }).ToList();

            ViewBag.v1 = valueCategory;
            ViewBag.v2 = valueWriter;
            return View();  
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.Add(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Name,
                                                      Value = x.CategoryId.ToString(),
                                                  }).ToList();

            ViewBag.v1 = valueCategory;
            return View();
        }

     
    }
}