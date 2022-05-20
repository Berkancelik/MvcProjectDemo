using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System.Web.Mvc;

namespace MvcProjectDemo.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager (new EfContactDal());
        public ActionResult Index()
        {
            var contactValues = cm.GetList();
            return View(contactValues);
        }

        public ActionResult GetContactDdetails(int id)
        {
            var contactValues = cm.GetById(id); 
            return View(contactValues);  
        }

        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = cm.GetById(id);
            return View(values);
        }


        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}