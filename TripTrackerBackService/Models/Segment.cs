using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTrackerBackService.Models
{
    public class Segment
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int Tripid { get; set; }

        public string Description { get; set; }

        public DateTimeOffset StartDateTime { get; set; }


        public DateTimeOffset EndDateTime { get; set; }

        //public void Test()
        //{
        //    StartDateTime.Offset
        //}
    }
}
