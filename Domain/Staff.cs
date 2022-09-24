using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Applicationcore.Domain
{
    public class Staff: Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public int salary { get; set; }
        public string function { get; set; }
    }
}
