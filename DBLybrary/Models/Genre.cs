using System;
using System.Collections.Generic;

namespace DBLybrary.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Book = new HashSet<Book>();
        }

        public long GenId { get; set; }
        public string GenName { get; set; }
        public string GenDescription { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
