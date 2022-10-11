using ST10131083_DAF.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ST10131083_DAF.Models.Dashboard
{
    public class Donation
    {
        [Key]
        public int Donationid { get; set; }
        [Required(ErrorMessage = "Please enter amount")]
        public double Amount { get; set; }
        [Required(ErrorMessage = "Please enter email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "Please enter surname")]
        public string Lname { get; set; }
        [Required(ErrorMessage = "Please enter mobile number")]
        public long Mobile { get; set; }
        [Required(ErrorMessage = "Please enter mobile date")]
        public DateTime Date { get; set; }
        public bool isPrivate { get; set; }
        /*public int Userid { get; set; }
        [ForeignKey("Userid")]
        public virtual User User { get; set; }*/

    }
}
