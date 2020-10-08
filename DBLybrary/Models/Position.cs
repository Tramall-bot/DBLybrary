using System;
using System.Collections.Generic;

namespace DBLybrary.Models
{
    public partial class Position
    {
        public Position()
        {
            Employee = new HashSet<Employee>();
        }

        public long PosId { get; set; }
        public string PosName { get; set; }
        public long PosSalary { get; set; }
        public string PosDuties { get; set; }
        public string PosRequirements { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
