using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KsiaznicaCsharp.Models
{
    public class UserData
    {

        public int UserId { get; set; }

        public string UserLogin { get; set; }

        public string UserPassword { get; set; }

        public DateTime UserJoinDate { get; set; }

        [EmailAddress(ErrorMessage = "Błędny format adresu email!")]
        public string UserEmail { get; set; }

        public string UserAvatar { get; set; }
    }
}