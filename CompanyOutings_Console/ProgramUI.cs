using CompanyOutings_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CompanyOutings_Repository.Events;

namespace CompanyOutings_Console
{
    class ProgramUI
    {
        private EventsRepository _eventsRepo = new EventsRepository();
        //private decimal costPerEvent;
        //private decimal combinedCost;
        //public decimal totalCombinedCost()
        //{
        //    return combinedCost += combinedCost;
        //}

        public void Run()
        {
            SeedContentList();
            AppMenu();
        }

        private void AppMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Welcome accountants! Please select an option from the menu below.\n" +
                    "1. See all outings\n" +
                    "2. Add new outing\n" +
                    "3. See outing costs by type\n" +
                    "4. See combined costs for all outings\n" +
                    "5. Exit");

                // User Input
                string input = Console.ReadLine();

                // Evaluate Input
                switch (input)
                {
                    case "1":
                        // see all outings
                        DisplayAllEvents();
                        break;
                    case "2":
                        // Create new outing - check
                        CreateNewEvent();
                        break;
                    case "3":
                        // see combined costs for all outings 
                        DisplayCostsForEvents();
                        break;
                    case "4":
                        // see outing costs by type 
                        DisplayCostsByEventType();
                        break;
                    case "5":
                        // exit
                        Console.WriteLine("Have a good day!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid option");
                        break;
                }

                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Create new event
        private void CreateNewEvent()
        {
            Console.Clear();

            Events newContent = new Events();
            // Event Type - Enum
            Console.WriteLine("What type of event would you like to add?\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert\n");

            string eventAsString = Console.ReadLine();
            int eventAsInt = int.Parse(eventAsString);
            newContent.TypeOfEvent = (EventType)eventAsInt;             // Casting? Not sure

            // Attendee Count - int
            Console.WriteLine("How many people will be attending?");
            string attendeesAsString = Console.ReadLine();
            newContent.Attendees = int.Parse(attendeesAsString);

            //  Date - string
            Console.WriteLine("When will the event take place?");
            newContent.DateOfEvent = Console.ReadLine();

            _eventsRepo.AddOutingToList(newContent);
        }

        // See all outings
        private void DisplayAllEvents()
        {
            Console.Clear();
            List<Events> listOfEvents = _eventsRepo.GetEventsList();

            foreach (Events events in listOfEvents)
            {
                Console.WriteLine($"Outings: {events.TypeOfEvent}\n" +
                    $"Number of Attendees: {events.Attendees}\n" +
                    $"Date of Event: {events.DateOfEvent}\n" +
                    $"Cost per Attendee: {events.CostPerEvent}\n" +
                    $"Cost of Event: {events.CombinedCost}\n\n");
            }
        }

        // Display the combined costs for all outings
        private void DisplayCostsForEvents()
        {
            Console.Clear();
            List<Events> listOfEvents = _eventsRepo.GetEventsList();

            decimal golfTotal = _eventsRepo.TotalCombinedCosts(EventType.Golf);
            decimal amusementParkTotal = _eventsRepo.TotalCombinedCosts(EventType.Amusement);
            decimal bowlingTotal = _eventsRepo.TotalCombinedCosts(EventType.Bowling);
            decimal concertTotal = _eventsRepo.TotalCombinedCosts(EventType.Concert);

            Console.WriteLine($"Total Golf: {golfTotal}");    
            Console.WriteLine($"Total Amusement Park: {amusementParkTotal}");    
            Console.WriteLine($"Total Bowling: {bowlingTotal}");    
            Console.WriteLine($"Total Concert: {concertTotal}");    
        }

        public void DisplayCostPerEvent()
        {
            List<Events> list = _eventsRepo.GetEventsList();
            foreach (Events e in list)
            {
                if (e.TypeOfEvent == EventType.Amusement)
                {
                    Console.WriteLine($"Amusement park cost {e.CostPerEvent}");
                }
            }
        }

        // Display of Outing Costs by type
        private void DisplayCostsByEventType()
        {
            Console.Clear();
            List<Events> listOfEvents = _eventsRepo.GetEventsList();

            foreach (Events events in listOfEvents)
            {
                Console.WriteLine($"Outings: {events.TypeOfEvent}\n" +
                   $"Date of Event: {events.DateOfEvent}\n" +
                   $"Cost per Attendee: {events.CostPerEvent}\n" +
                   $"Cost of Event: {events.CombinedCost}\n\n");
            }
        }

        private void SeedContentList()
        {
            Events firstEvent = new Events(EventType.Amusement, 10, "8.31.21", 1.5m, 10.5m);
            Events secondEvent = new Events(EventType.Amusement, 1, "10.16.21", 1.5m, 10.5m);
            Events thirdEvent = new Events(EventType.Bowling, 10, "12.26.21", 1.5m, 10.5m);

            _eventsRepo.AddOutingToList(firstEvent);
            _eventsRepo.AddOutingToList(secondEvent);
            _eventsRepo.AddOutingToList(thirdEvent);
        }
    }
}

