using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOutings_Repository
{
    public class EventsRepository
    {
        private List<Events> _listOfEvents = new List<Events>();

        // Create
        public void AddOutingToList(Events outings)
        {
            _listOfEvents.Add(outings);
        }

        // Read
        public List<Events> GetEventsList()
        {
            return _listOfEvents;
        }

        public decimal TotalEventCost()
        {
            decimal totalCost = 0;
            foreach (Events events in _listOfEvents)
            {
                totalCost += events.CombinedCost;
            }
            return totalCost;
        }

        public decimal TotalCombinedCosts(Events.EventType eventType)
        {
            decimal totalCost = 0;
            foreach (Events events in _listOfEvents)
            {
                if (events.TypeOfEvent == eventType)
                    totalCost += events.CombinedCost;
            }
            return totalCost;
        }
    }
}



