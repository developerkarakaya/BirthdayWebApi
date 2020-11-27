using BirthdayWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayWebApi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DavetiyeFormu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DavetiyeFormu(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.katilanlar = Veritabani.Liste.Where(ss => ss.KatilmaDurumu == true);
                Veritabani.Add(model);
                return View("Thanks", model);
            }
            return View();
        }

        [ChildActionOnly]
        public ActionResult Katilanlar()
        {
            return PartialView(Veritabani.Liste.Where(ss => ss.KatilmaDurumu == true).ToList());
        }
    }
}