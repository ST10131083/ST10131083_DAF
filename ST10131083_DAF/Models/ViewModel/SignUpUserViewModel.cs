using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ST10131083_DAF.Models.ViewModel
{
    public class SignUpUserViewModel
    {
        public int Userid { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Active")]
        public bool isActive { get; set; }
    }
}
