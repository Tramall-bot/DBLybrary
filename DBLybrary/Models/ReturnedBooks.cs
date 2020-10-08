using System;
using System.Collections.Generic;

namespace DBLybrary.Models
{
    public partial class ReturnedBooks
    {
        public byte[] RbReturnDate { get; set; }
        public byte[] RbGiveOutDate { get; set; }
        public long RbReturnFlag { get; set; }
        public long EmpId { get; set; }
        public long RdId { get; set; }
        public long BkId { get; set; }

        public virtual Book Bk { get; set; }
        public virtual Employee Emp { get; set; }
        public virtual Reader Rd { get; set; }
    }
}
