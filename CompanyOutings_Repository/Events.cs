using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOutings_Repository
{
    public class Events
    {
        public enum EventType
        {
            Golf = 1,
            Bowling,
            Amusement,
            Concert
        }
        public EventType TypeOfEvent { get; set; }
        public int Attendees { get; set; }
        public string DateOfEvent { get; set; }
        public decimal CostPerEvent
        {
            get
            {
                switch (TypeOfEvent)
                {
                    case EventType.Golf:
                        return 20.00m;
                    case EventType.Bowling:
                        return 10.00m;
                    case EventType.Amusement:
                        return 30.00m;
                    case EventType.Concert:
                        return 20.00m;
                    default:
                        return 0.00m;
                }
            }
        }
        public decimal CombinedCost
        {
            get
            {
                return Attendees * CostPerEvent;
            }
        }

        //public decimal TotalCombinedCost
        //{
        //    get
        //    {
        //        return CostPerEvent + CostPerEvent;
        //    }
        //}

        public Events() { }
        public Events(EventType typeOfEvent, int attendees, string dateOfEvent, decimal costPerEvent, decimal combinedCost)
        {
            TypeOfEvent = typeOfEvent;
            Attendees = attendees;
            DateOfEvent = dateOfEvent;
            // CostPerEvent = costPerEvent;
            // CombinedCost = combinedCost;
        }
    }
}
