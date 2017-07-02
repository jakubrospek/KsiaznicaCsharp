using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KsiaznicaCsharp.Models
{
    public class Ratings
    {
        public int RatingsId { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        public float RatingsValue { get; set; }


        //public virtual UserData User { get; set; }

        public virtual Book Book { get; set; }
    }
}