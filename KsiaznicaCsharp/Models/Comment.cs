using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KsiaznicaCsharp.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public int BookId { get; set; }

        public int UserId { get; set; }

        public string CommentAddedBy { get; set; }

        public string CommentText { get; set; }

        public string CommentRating { get; set; }

        public DateTime CommentDateAdded { get; set; }



        //public virtual UserData User { get; set; }

        public virtual Book Book { get; set; }
    }
}