using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTicariOtomasyon.Models.Siniflar;

namespace MVCTicariOtomasyon.Controllers
{
    public class YapilacakController : Controller
    {
        // GET: Yapilacak
        Context c = new Context();
        public ActionResult Index()
        {
            var sorgu = c.Carilers.Count().ToString();
            ViewBag.d1 = sorgu;
            var sorgu2 = c.Uruns.Count().ToString();
            ViewBag.d2 = sorgu2;
            var sorgu3 = c.Kategoris.Count().ToString();
            ViewBag.d3 = sorgu3;
            var sorgu4 = (from x in c.Carilers select x.CariSehir).Distinct().Count().ToString();
            ViewBag.d4 = sorgu4;


            var yapilacaklar = c.Yapilacaks.ToList();
            
            return View(yapilacaklar);
        }
    }
}