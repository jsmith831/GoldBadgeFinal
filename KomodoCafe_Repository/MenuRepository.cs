using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe_Repository
{
    public class MenuRepository
    {
        private List<Menu> _listOfItems = new List<Menu>();

        // Create
        public void AddItemsToList(Menu items)
        {
            _listOfItems.Add(items);
        }

        // Read
        public List<Menu> GetMenuList()
        {
            return _listOfItems;
        }

        // Delete
        public bool RemoveItemFromList(string mealName)
        {
            Menu item = GetItemByName(mealName);

            if (item == null)
            {
                return false;
            }

            int initialCount = _listOfItems.Count;
            _listOfItems.Remove(item);

            if(initialCount > _listOfItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Helper Method
        public Menu GetItemByName(string mealName)
        {
            foreach(Menu item in _listOfItems)
            {
                if (item.MealName == mealName)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
