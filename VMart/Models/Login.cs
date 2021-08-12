using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VMart.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Display(Name = "User Name ")]
        public string Email { get; set; }

        [Display(Name = "Password ")]
        public string Password { get; set; }

    }
}
