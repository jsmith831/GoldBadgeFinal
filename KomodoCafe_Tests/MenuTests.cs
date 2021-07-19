using KomodoCafe_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoCafe_Tests
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void SetMealName_ShouldSetCorrectString()
        {
            Menu item = new Menu();

            item.MealName = "Double Cheese";

            string expected = "Double Cheese";
            string actual = item.MealName;

            Assert.AreEqual(expected, actual);
        }
        public void SetMealNumber_ShouldSetCorrectString()
        {
            Menu item = new Menu();
             
            item.MealNumber = 1;

            int expected = 1;
            int actual = item.MealNumber;

            Assert.AreEqual(expected, actual);
        }
        public void SetDesciption_ShouldSetCorrectString()
        {
            Menu item = new Menu();

            item.Description = "Twice as many patties, same amount bread.";

            string expected = "Twice as many patties, same amount bread.";
            string actual = item.Description;

            Assert.AreEqual(expected, actual);
        }   
        public void SetIngredients_ShouldSetCorrectString()
        {
            Menu item = new Menu();

            item.Ingredients = "Ketchup, mustard, tomato, pickles and cheese.";

            string expected = "Ketchup, mustard, tomato, pickles and cheese.";
            string actual = item.Ingredients;

            Assert.AreEqual(expected, actual);
        }   
        public void SetPrice_ShouldSetCorrectString()
        {
            Menu item = new Menu();

            item.Price = "$5.00";

            string expected = "$5.00";
            string actual = item.Price;

            Assert.AreEqual(expected, actual);
        }   
    }
}
