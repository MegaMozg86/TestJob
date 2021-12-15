using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestJob.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Display(Name = "Марка")]
        public string Brand { get; set; }
        [Display(Name = "Модель")]
        public string Model { get; set; }
        [Display(Name = "Цвет")]
        public string Color { get; set; }
        [Display(Name = "Комплектация")]
        public string Equipment { get; set; }
        [Display(Name = "Цена")]
        public double Price { get; set; }
    }
}