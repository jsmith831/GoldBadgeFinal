using KomodoCafe_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoCafe_Tests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        private MenuRepository _repo;
        private Menu _item;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _item = new Menu(1, "Double Cheese", "Twice as many patties, same amount of bread", "Ketchup, mustard, tomato, pickles and cheese", "$5.00");

            _repo.AddItemsToList(_item);
        }


        [TestMethod]
        public void AddToList_ShouldNotGetNull()
        {
            Menu item = new Menu();
            item.MealName = "Double Cheese";
            MenuRepository repository = new MenuRepository();

            repository.AddItemsToList(item);
            Menu itemFromDirectory = repository.GetItemByName("Double Cheese");

            Assert.IsNotNull(itemFromDirectory);
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            bool deleteResult = _repo.RemoveItemFromList(_item.MealName);

            Assert.IsTrue(deleteResult);
        }
    }
}
