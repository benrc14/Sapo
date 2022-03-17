﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Sapo.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
