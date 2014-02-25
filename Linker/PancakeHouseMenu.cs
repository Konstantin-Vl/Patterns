using System.Collections;

namespace Linker
{
    public class PancakeHouseMenu : IEnumerable
    {
        private readonly ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();

            AddItem("Pancake1", "Description1", false, 1.2);
            AddItem("Pancake2", "Description2", true, 0.2);
            AddItem("Pancake3", "Description3", false, 4.1);
            AddItem("Pancake4", "Description4", true, 2.0);
            AddItem("Pancake4", "Description4", true, 2.0);
            AddItem("Pancake4", "Description4", true, 2.0);
        }

        private void AddItem(string name, string description, bool isVegeterian, double price)
        {
            var menuItem = new MenuItem(name, description, isVegeterian, price);
            _menuItems.Add(menuItem);
        }

        public IEnumerator GetEnumerator()
        {
            return _menuItems.GetEnumerator();
        }
    }
}
