using KomodoCafe_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_Console
{
    class ProgramUI
    {
        private MenuRepository _itemRepo = new MenuRepository();
        public void Run()
        {
            SeedMenuList();
            AppMenu();
        }

        private void AppMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                Console.WriteLine("Welcome to The Komodo Cafe! Please see below for menu options.\n" +
                    "1. Create New Menu Item\n" +
                    "2. Delete Menu Item\n" +
                    "3. See All Menu Items\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateNewItem();
                        break;

                    case "2":
                        DeleteMenuItem();
                        break;

                    case "3":
                        DisplayAllItems();
                        break;

                    case "4":
                        Console.WriteLine("Until Next Time, Happy Hamburgers!");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please select a number from the menu.");
                        break;
                }

                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateNewItem()
        {
            Console.Clear();

            Menu newItem = new Menu();

            // Meal Number
            Console.WriteLine("Enter the value number:");
            newItem.MealNumber = int.Parse(Console.ReadLine());

            // Meal Name
            Console.WriteLine("Enter the Meal Name: ");
            newItem.MealName = Console.ReadLine();

            // Description
            Console.WriteLine("Enter the Description of the meal: ");
            newItem.Description = Console.ReadLine();

            // Ingredients
            Console.WriteLine("Enter the Ingredients: ");
            newItem.Ingredients = Console.ReadLine();

            // Price
            Console.WriteLine("Enter the Price of the Meal: ");
            newItem.Price = Console.ReadLine();

            _itemRepo.AddItemsToList(newItem);
        }

        private void DeleteMenuItem()
        {
            DisplayAllItems();

            Console.WriteLine("\nWhich item needs tar and feathered?");
            string input = Console.ReadLine();

            bool wasDeleted = _itemRepo.RemoveItemFromList(input);

            if (wasDeleted)
            {
                Console.WriteLine("Sammich successfully tossed.");
            }
            else
            {
                Console.WriteLine("Oops... That burg must have wings. Item not deleted.");
            }

        }

        private void DisplayAllItems()
        {
            Console.Clear();
            List<Menu> listOfItems = _itemRepo.GetMenuList();

            foreach (Menu item in listOfItems)
            {
                Console.WriteLine($"Meal Name: {item.MealName}\n" +
                    $" Description: {item.Description}\n" +
                    $" Ingredients: {item.Ingredients}\n\n");
            }
        }
        private void SeedMenuList()
        {
            Menu doubleCheese = new Menu(1, "Double Cheese", "Twice as much meat, same amount of bread", "Two beef patties, two slices of cheese, ketchup, mustard and pickles", "$8.31");
            Menu littleCheese = new Menu(2, "Little Cheese", "Little burg for little people", "One beef pattie, one slice of cheese, ketchup, mustard and pickles", "$5.31");
            Menu komodoChicken = new Menu(3, "Komodo Chicken", "If you don't know, you don't want to", "Komodo Chicken breast, pickles and choice of Komodo Sauce or Komodo Dragon Sauce", "$10.31");

            _itemRepo.AddItemsToList(doubleCheese);
            _itemRepo.AddItemsToList(littleCheese);
            _itemRepo.AddItemsToList(komodoChicken);
        }
    }
}
