﻿using System.ComponentModel.DataAnnotations;

namespace JWTAuthenticationDemo
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
