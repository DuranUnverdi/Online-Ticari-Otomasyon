using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTicariOtomasyon.Models.Siniflar;

namespace MVCTicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        Context c = new Context();
        // GET: UrunDetay
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            //var degerler = c.Uruns.Where(x => x.UrunID == 1).ToList();
            cs.Deger1 = c.Uruns.Where(x => x.UrunID == 10).ToList();
            cs.Deger2 = c.Detays.Where(x => x.DetayID == 1).ToList();
            return View(cs);
        }
    }
}