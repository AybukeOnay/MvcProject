using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            var adminvalues = adminManager.GetList();
            return View(adminvalues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            //List<SelectListItem> valueadmin = (from x in adminManager.GetList()
            //                                      select new SelectListItem
            //                                      {
            //                                          Text = x.AdminRole,
            //                                          Value = x.AdminID.ToString()
            //                                      }).ToList();
            
            //ViewBag.vlc = valueadmin;

            adminManager.AdminAddBL(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminvalues = adminManager.GetByID(id);
            return View(adminvalues);
        }
        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            adminManager.AdminUpdateBL(p);
            return RedirectToAction("Index");
        }
    }
}