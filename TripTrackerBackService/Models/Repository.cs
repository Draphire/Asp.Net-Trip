using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTrackerBackService.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip
            {
                id = 1,
                Name = "MVP Summit",
                StartDate  = new DateTime(2018, 3, 5),
                EndDate = new DateTime(2018, 3, 8)
            },
              new Trip
            {
                id = 2,
                Name = "DevIntersection Orlando 2018",
                StartDate  = new DateTime(2018, 3, 25),
                EndDate = new DateTime(2018, 3, 27)
            },
                 new Trip
            {
                id = 3,
                Name = "Build 2018",
                StartDate  = new DateTime(2018, 5, 7),
                EndDate = new DateTime(2018, 5, 9)
            }
        };
        public List<Trip> Get()
        {
            return MyTrips;
        }
        public Trip Get(int id)
        {
            return MyTrips.First(t => t.id == id);
        }

        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.id == tripToUpdate.id));
            Add(tripToUpdate);
        }

        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.id == id));

        }
    }
}
