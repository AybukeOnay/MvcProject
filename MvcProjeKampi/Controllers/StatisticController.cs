using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            //Toplam kategori sayısı
            var totalCategory = context.Categories.Count();
            ViewBag.totalCategory = totalCategory;

            //Başlık kategorisinde oyun kategorisi sayısı
            var subtitleGameCount = context.Headings.Count(x => x.CategoryID == 5);
            ViewBag.subtitleGame = subtitleGameCount;

            // Yazar adında "a" harfi geçen yazar sayısı
            var novelistName = (from n in context.Writers
                                select n.WriterName.IndexOf("a")).Distinct().Count();
            ViewBag.novelistName = novelistName;

            //En fazla başlığa sahip kategori adı
            var categoryTitle = context.Categories.Where(c => c.CategoryID == context.Headings.GroupBy(b => b.CategoryID)
                                                         .OrderByDescending(y => y.Count()).Select(a => a.Key)
                                                         .FirstOrDefault()).Select(z => z.CategoryName).FirstOrDefault();
            ViewBag.categoryTitle = categoryTitle;

            // Kategori tablosunda durumu true olanlar
            var categoryStatusTrue = context.Categories.Count(x => x.CategoryStatus == true); 
            ViewBag.categoryStatusTrue = categoryStatusTrue;

            return View();
        }
    }
}