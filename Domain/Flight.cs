using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Applicationcore.Domain
{
    public class Flight
    {

        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public String Departure { get; set; }
        public String Destination { get; set; }
        public Plane Plane { get; set; }
        public IList<Passenger> Passengers { get; set; }

        public override string ToString()
        {
            return "FlightId:" + FlightId+ "FlightDate:" + FlightDate+ "EstimatedDuration:" + EstimatedDuration+ "EffectiveArrival:" + EffectiveArrival+ "Departure:" + Departure+ "Destination:" + Destination+ "Plane:" + Plane+ "Passengers:" + Passengers;
        }




    }
}
