using Am.Applicationcore.Domain;
using Am.Applicationcore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Am.Applicationcore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        //créer une liste de flight qui est une instance de flight
        public List<Flight> flight = new List<Flight>();
        // public List<Plane> plane = new List<Plane>();
        public List<Flight> lf = new List<Flight>();
        public List<DateTime> ld = new List<DateTime>();

        public float DurationAverage(string destination)
        {
            //int nb;
            //int duree = 0;
            //foreach (Flight f in flight)
            //{
            //    if (f.Destination == destination)
            //        ld.Add(f.EstimatedDuration);
            //}
            //for (int i=0; i < ld.Count; i++)
            //{
            //   duree+= ld[i].Hour * 60 + ld[i].Minute;
            //}
            //nb= duree/ld.Count;


            //return nb; 
            var duree = from f in flight
                        where f.Destination.Equals(destination)
                        select f.EstimatedDuration;

            int nb = (from x in duree select x.Minute+x.Hour*60).Sum();
                //duree.Sum(x => x.Hour * 60 + x.Minute);
                int lenght= duree.Count();
            int moy= nb/lenght;


            return moy;

        }

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> ls = new List<DateTime>();
            //parcourir la liste de flight
            /*for (int i = 0; i < Flight.Count; i++)
            {
                //comparer la destination actuelle avec celle passée en paramètre
               if (Flight[i].Destination == destination)
                    //ajouter  la date actuelle dans la liste de date
                    ls.Add(Flight[i].FlightDate);
            }*/


            //-------------------------------------------------------------------------//

            /* foreach (Flight f in Flight)
             {
                 if (f.Destination == destination)
                     ls.Add(f.FlightDate);
             }
             return ls;*/



            //-------------------------------------------------------------------------------//

            var query = from f in flight
                        where f.Destination.Equals(destination)
                        //in Flight.Where(f => f.Destination == destination)
                        select f.FlightDate;
            return query.ToList();
        }

        public List<Flight> GetFlights(string filterType, string filterValue)
        {

           switch(filterType)
            {
                case "FlightDate":
                    lf.Clear();
                    foreach (Flight f in flight)
                    {
                        if(f.FlightDate.ToString() == filterValue)
                     lf.Add(f);
                    }
                    
                    break;

                case "EstimatedDuration":
                    lf.Clear();
                    foreach (Flight f in flight)
                    {
                        if (f.EstimatedDuration.ToString() == filterValue)
                            lf.Add(f);
                    }
                    break;

                case "EffectiveArrival":

                    lf.Clear();
                    foreach (Flight f in flight)
                    {
                        if (f.EffectiveArrival.ToString() == filterValue)
                            lf.Add(f);
                    }
                    
                    break;

                case "Departure":
                    lf.Clear();
                    foreach (Flight f in flight)
                    {
                        if (f.Departure == filterValue)
                            lf.Add(f);
                    }

                    break;

                case "Destination":
                    lf.Clear();
                    foreach (Flight f in flight)
                    {
                        if (f.Destination == filterValue)
                            lf.Add(f);
                    }

                    break;

            }
            return lf;

        }

        public List<Flight> OrderedDurationFlights()
        {
            var liste = from f in flight
                        orderby f.EstimatedDuration descending
            select f;

          return liste.ToList();

        }

        public void ShowFlightDetails(Plane p)
        {
            var query = from f in flight
                       where f.Plane.Equals(p)
                       //new et les accolades pour afficher deux valeurs
                       select new { f.FlightDate, f.Destination };
            //return query;
            foreach (var v in query)
            {
                Console.WriteLine("la destination est:" + v.Destination + "la date est:" + v.FlightDate);
            }
        }
    }
}




   

    
            
        

       
   




