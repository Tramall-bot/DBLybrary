using System;
using System.Collections.Generic;

namespace DBLybrary.Models
{
    public partial class Employee
    {
        public long EmpId { get; set; }
        public string EmpFullName { get; set; }
        public long EmpAge { get; set; }
        public string EmpSex { get; set; }
        public string EmpAddress { get; set; }
        public string EmpPhoneNumber { get; set; }
        public string EmpPassportData { get; set; }
        public long PosId { get; set; }

        public virtual Position Pos { get; set; }
    }
}
