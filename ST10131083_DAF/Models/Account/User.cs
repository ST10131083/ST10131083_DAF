﻿using System.ComponentModel.DataAnnotations;

namespace ST10131083_DAF.Models.Account
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }
    }
}
