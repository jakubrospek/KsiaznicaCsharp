using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KsiaznicaCsharp.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Musisz wprowadzić Login")]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić Hasło")]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Zapamiętaj mnie")]
        public bool RememberMe { get; set; }

        // rozkminić o co chodzi na filmie - "ASP.NET Identity - mechanizm logowania" - praktyka
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić Login")]
        [Display(Name = "Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić Hasło")]
        [StringLength(100, ErrorMessage = "{0} musi mieć przynajmniej {2} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Musisz potwierdzić Hasło")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}