using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VMart.Models
{
    public class Items
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        public int Price { get; set; }


        [Display(Name = "Quantity")]
        public int Qty { get; set; }

      

    }
}
