using System;
using System.Collections.Generic;

namespace DBLybrary.Models
{
    public partial class Book
    {
        public long BkId { get; set; }
        public string BkName { get; set; }
        public string BkAuthor { get; set; }
        public byte[] BkRealiseDate { get; set; }
        public long PubId { get; set; }
        public long GenId { get; set; }

        public virtual Genre Gen { get; set; }
        public virtual Publisher Pub { get; set; }
    }
}
