using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthdayWebApi.Models
{
    public class DavetiyeModel
    {
        [Required]
        public String Ad { get; set; }

        [Required]
        public String Eposta { get; set; }

        [Required]
        public bool? KatilmaDurumu { get; set; }
    }
}