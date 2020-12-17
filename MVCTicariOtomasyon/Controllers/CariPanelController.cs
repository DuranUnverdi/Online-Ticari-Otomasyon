using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTicariOtomasyon.Models.Siniflar;

namespace MVCTicariOtomasyon.Controllers
{
    public class CariPanelController : Controller
    {  
        Context c = new Context();
        // GET: CariPanel
        [Authorize]//webconfig alanına autorize ekledik ve buradan da yetkili olmayan kişilerin
        //girmesini engelleiyoruz
      
        public ActionResult Index()
        {
            var mail = (string)Session["CariMaiil"];
            var degerler = c.Carilers.FirstOrDefault(x => x.CariMaiil == mail);
            ViewBag.m = mail;
            return View(degerler);
        }
        public ActionResult Siparislerim()
        {
            var mail = (string)Session["CariMaiil"];
            var id = c.Carilers.Where(x => x.CariMaiil == mail.ToString()).Select(y => y.CariID).FirstOrDefault();
            var degerler = c.SatisHarekets.Where(x => x.Cariid == id).ToList();
            return View(degerler);
        }
        public ActionResult GelenMesajlar()
        {
            var mesajlar = c.Mesajlars.ToList();
            return View(mesajlar);
        }
        //[HttpGet]
        //public ActionResult YeniMesaj()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult YeniMesaj()
        //{
        //    return View();
        //}
    }
}