using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ST10131083_DAF.Models.ViewModel
{
    public class LoginSignUpViewModel
    {

        public string Email { get; set; }
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool isRemember { get; set; }
    }
}
