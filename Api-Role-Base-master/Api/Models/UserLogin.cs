﻿using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class UserLogin
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }    

    }
}
