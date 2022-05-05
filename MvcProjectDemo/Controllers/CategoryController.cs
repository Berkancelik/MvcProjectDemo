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
    public class CategoryController : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }

        //[HttpPost]
        //public ActionResult AddCategory(Category p)
        //{
        //    cm.CategpryAddBL(p);    
        //    return RedirectToAction("GetCategoryList");
         
        //}

        //[HttpGet]
        //public ActionResult AddCategory()
        //{
        //    return View();

        //}
    }
}