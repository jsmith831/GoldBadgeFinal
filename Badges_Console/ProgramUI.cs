using Badges_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badges_Console
{
    class ProgramUI
    {
        public void Run()
        {
            //SeedMenuList();
            AppMenu();
        }

        private void AppMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                Console.WriteLine("Hello Security Admin! Please select and item from the list below.\n" +
                    "1. Create a New Badge\n" +
                    "2. Update Doors on Existing Badge\n" +
                    //"3. Delete All Doors From an Existing Badge\n" +
                    "3. Show All Badge Numbers and Door Access\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input) 
                {
                    case "1":
                        // Create
                        CreateNewBadge();
                        break;

                    case "2":
                        // Update Doors on Badge
                        UpdateDoorsOnBadge();
                        break;

                    //case "3":
                    //    // Delete All Doors on a Given Badge
                    //    DeleteDoorsFromBadge();
                    //    break;

                    case "3":
                        // Show All Badge Numbers and Door Access 
                        DisplayAllBadges();
                        break;

                    case "4":
                        Console.WriteLine("Goodbye.");
                        keepRunning = false;
                        break;

                    default:
                        Console.Write("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue");

                Console.ReadKey();
                Console.Clear();
            }
        }

        // Create New
        private void CreateNewBadge()
        {
            Badges newBadges = new Badges();

            // What is the number on the badge?

            // List a door it needs access to: 

            // Any other doors? (y/n)

                    }

        // Update Doors on Badge
        private void UpdateDoorsOnBadge()
        {
            // What is the badge number you want to update?

            // (Badge #) has access to Doors XXX, XXX, XXX

            // What would you like to do?
                // 1. Add a Door
                // 2. Remove a Door

            // If 1 - Which door would you like to add?
                // User input
                // "Door Added"

            // If 2 - Which door would you like to remove?
                // User input
                // "Door Removed"

            // Either way - "Door has access to door(s) XXX, XXX

        }

        // Delete Doors From Badge - Should be in Update Method?
        //private void DeleteDoorsFromBadge()
        //{

        //}

        // Show All Badge Numbers and Door Access
        private void DisplayAllBadges()
        {
            // Badge #      Door Access
            // 1234         A7
            // 2345         A1, A2
            // 3456         B1, B2
        }

    }
}
