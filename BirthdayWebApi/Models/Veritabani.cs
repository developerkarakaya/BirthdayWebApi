using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayWebApi.Models
{
    public static class Veritabani
    {


        private static Dictionary<string, DavetiyeModel> _liste;


        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();

            _liste.Add("Samet", new DavetiyeModel
            {
                Ad = "Samet",
                Eposta = "sametkarakaya14@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Abdullah", new DavetiyeModel
            {
                Ad = "Abdullah",
                Eposta = "abdullahyilmaz@gmail.com",
                KatilmaDurumu = false
            });

            _liste.Add("Hayrettin", new DavetiyeModel
            {
                Ad = "Hayrettin",
                Eposta = "haurettincelik@gmail.com",
                KatilmaDurumu = true
            });
        }

        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }

        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; }
        }
    }
}