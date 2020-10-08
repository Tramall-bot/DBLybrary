using System;
using System.Collections.Generic;

namespace DBLybrary.Models
{
    public partial class Reader
    {
        public long RdId { get; set; }
        public string RdFullName { get; set; }
        public byte[] RdBdDate { get; set; }
        public string RdSex { get; set; }
        public string RdAddress { get; set; }
        public string RdPhoneNumber { get; set; }
        public string RdPassportData { get; set; }
    }
}
