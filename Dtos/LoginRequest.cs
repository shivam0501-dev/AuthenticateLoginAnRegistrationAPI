﻿using System.ComponentModel.DataAnnotations;

namespace AuthenticateLoginAnRegistration.Dtos
{
    public class LoginRequest
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
