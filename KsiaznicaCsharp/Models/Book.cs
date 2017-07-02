using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KsiaznicaCsharp.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookAuthor { get; set; }

        public string BookTitle { get; set; }

        public string BookCycle { get; set; }

        public string BookVolume { get; set; }

        public string BookTranslation { get; set; }

        public string BookOriginalTitle { get; set; }

        public string BookISBN { get; set; }

        public string BookNrPages { get; set; }

        public string BookGenre { get; set; }

        public string BookLanguage { get; set; }

        public string BookDescription { get; set; }

        public string BookCover { get; set; }
    }
}