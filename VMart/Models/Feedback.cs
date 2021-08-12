using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VMart.Models
{
    public class Feedback
    {
        public int id { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Email")]
        public string sEmail { get; set; }


        [Display(Name = "Contact ")]
        public string Contact { get; set; }


        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
