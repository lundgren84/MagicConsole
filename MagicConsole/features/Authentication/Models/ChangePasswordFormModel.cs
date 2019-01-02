using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagicConsole.features.Authentication.Models
{
    public class ChangePasswordFormModel
    {
        [Required(ErrorMessage = "Field required")]
        [Display(Name = "E-mail / Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Field required")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}