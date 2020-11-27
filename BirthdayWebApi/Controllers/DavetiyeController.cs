using BirthdayWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthdayWebApi.Controllers
{
    public class DavetiyeController : ApiController
    {

        public IEnumerable<DavetiyeModel> GetKatilanlar()
        {
            return Veritabani.Liste.Where(ss => ss.KatilmaDurumu == true);
        }
        public IEnumerable<DavetiyeModel> GetKatilmayanlar()
        {
            return Veritabani.Liste.Where(ss => ss.KatilmaDurumu == false);
        }
        public void PostEkle(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);
            }
        }
    }
}
