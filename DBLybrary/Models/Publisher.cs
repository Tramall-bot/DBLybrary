using System;
using System.Collections.Generic;

namespace DBLybrary.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Book = new HashSet<Book>();
        }

        public long PubId { get; set; }
        public string PubName { get; set; }
        public string PubCity { get; set; }
        public string PubAddress { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
