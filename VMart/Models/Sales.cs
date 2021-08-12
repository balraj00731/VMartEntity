using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VMart.Models
{
    public class Sales
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Contact ")]
        public string Contact { get; set; }

        [Display(Name = "Designation ")]
        public string Desingation { get; set; }


    }
}
