using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormTagHelpers.Models
{
    public class Fruit
    {
        [Display(Name = "Your Name:")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public int Qty { get; set; }
    }
}
