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

        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName.Equals(firstName) && LastName.Equals(lastName);
            //return FirstName==firstName && LastName==fastName;
        }

        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return FirstName == firstName && LastName == lastName && EmailAddress==email;
        }

        public bool login(string firstName, string lastName, string email=null)
        {
            if (email!=null)
                return CheckProfile(firstName, lastName,email);
               //return FirstName == firstName && LastName == lastName && EmailAddress == email;
            return FirstName == firstName && LastName == lastName;

        }
        
        public virtual void PassengerType()
        {
            Console.WriteLine("i am passenger");
        }




    }
}
