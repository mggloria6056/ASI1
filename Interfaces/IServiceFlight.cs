using Am.Applicationcore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Applicationcore.Interfaces
{
   public interface IServiceFlight
    {
        List <DateTime> GetFlightDates (string destination);
        public List<Flight> GetFlights(string filterType, string filterValue);
        public void ShowFlightDetails(Plane p);
        public float DurationAverage(string destination);
        public List<Flight> OrderedDurationFlights();
    }
}
