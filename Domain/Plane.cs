using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am.Applicationcore.Domain
{
    public enum PlaneType
    {
        boing,
        airbus
    }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "capacity:" +Capacity+ "ManufactureDate:" + ManufactureDate+ "PlaneId:"+ PlaneId+ "Flights:"+ Flights;
        }

        public Plane( int capacity, DateTime manufactureDate,  PlaneType planeType)
        {
           
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planeType;
           
        }

        public Plane()
        {
        }
    }
}
