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

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategory()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }
        [HttpGet]
            public ActionResult AddCategory()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {

            //cm.AddCategory(category);
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid)
            {
                cm.CategoryAddBL(category);
                return RedirectToAction("GetCategory");
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