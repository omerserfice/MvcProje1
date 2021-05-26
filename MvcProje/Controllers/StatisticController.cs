using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class StatisticController : Controller
    {
        Context context = new Context();
        // GET: Statistic
        public ActionResult Index()
        {
            var deger = context.Categorys.Count().ToString();
            ViewBag.viewbag = deger;

            var deger1 = context.Headings.Count(x=>x.CategoryID==8).ToString();
            ViewBag.viewbag1 = deger1;

            var deger2 = context.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.viewbag2 = deger2;

            var deger3 = context.Categorys.Where(x=>x.CategoryID==context.Headings.GroupBy(h => h.CategoryID)
            .OrderByDescending(h => h.Count()).Select(h => h.Key).FirstOrDefault()).
            Select(h => h.CategoryName).FirstOrDefault();
            ViewBag.viewbag3 = deger3;

            var deger4 = Math.Abs(context.Categorys.Count(x => x.CategoryStatus == true) - context.Categorys.Count(x => x.CategoryStatus == false));
            ViewBag.viewbag4 = deger4;
            return View();

        }
    }
}