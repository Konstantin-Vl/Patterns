using System.Collections;

namespace Iterator
{
    public class CaffeMenu:IEnumerable
    {
        readonly Hashtable _menuItems = new Hashtable();

        public CaffeMenu()
        {
            AddItem("Name1", "Description1", false, 0.99);
            AddItem("Name2", "Description2", false, 2.29);
            AddItem("Name3", "Description3", true, 1.99);
            AddItem("Name4", "Description4", false, 0.99);
        }

        private void AddItem(string name, string description, bool isVegeterian, double price)
        {
            var menuItem = new MenuItem(name, description, isVegeterian, price);
            _menuItems.Add(menuItem.Name, menuItem);
        }

        public IEnumerator GetEnumerator()
        {
            return _menuItems.Values.GetEnumerator();
        }
    }
}
