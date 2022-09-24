using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Applicationcore.Domain
{
   public class Passenger
    {
        public string PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        public string EmailAddress { get; set; }
        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "PassportNumber:"+ PassportNumber+ "FirstName:" + FirstName+ "LastName:" + LastName+ "BirthDate:" + BirthDate+ "TelNumber:" + TelNumber + "EmailAddress:"+ EmailAddress+ "Flights:"+ Flights
                ;
        }
    }
}
