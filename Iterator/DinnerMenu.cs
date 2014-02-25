using System;
using System.Collections;

namespace Iterator
{
    public class DinnerMenu:IEnumerable
    {
        private readonly MenuItem[] _menuItems;
        private const int MaxSize = 6;
        private int _numberOfItems;

        public DinnerMenu()
        {
        _menuItems = new MenuItem[MaxSize];

            AddItem("Dinner1", "Description1", true, 2.3);
            AddItem("Dinner2", "Description2", false, 1.4);
            AddItem("Dinner3", "Description3", true, 2.0);
            AddItem("Dinner4", "Description4", true, 1);
            AddItem("Dinner4", "Description4", true, 1);
            AddItem("Dinner4", "Description4", true, 1);
        }

        private void AddItem(string dinner, string description, bool isVegeterian, double price)
        {
            if (_numberOfItems >= MaxSize)
                Console.WriteLine("Sorry, menu is full");
            else
            {
                var menuItem = new MenuItem(dinner, description, isVegeterian, price);
                _menuItems[_numberOfItems] = menuItem;
                _numberOfItems++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _menuItems.GetEnumerator();
        }
    }
}
