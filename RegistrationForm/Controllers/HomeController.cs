using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Registration(tbl_UserRegistration user)
        {
            WebAppEntities db = new WebAppEntities();
            db.tbl_UserRegistration.Add(user);
            db.SaveChanges();
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}