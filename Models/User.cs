﻿using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public class User
    {
        [Key] public Guid Id { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public required string Passwd { get; set; }

        [Display(Name = "RememberMe")]
        public bool RememberMe { get; set; }

        [Display(Name = "Login")]
        public bool LogIn { get; set; }
}

}
