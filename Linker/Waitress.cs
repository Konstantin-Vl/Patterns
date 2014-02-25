using System;
using System.Collections;

namespace Linker
{
    public class Waitress
    {
        private readonly ArrayList _menus;

        public Waitress(ArrayList menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
            var menuIterator = _menus.GetEnumerator();
            while (menuIterator.MoveNext())
            {
                var menu = (IEnumerable) menuIterator.Current;
                PrintMenu(menu.GetEnumerator());
            }
        }

        private static void PrintMenu(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                var menuItem = (MenuItem)iterator.Current;
                Console.WriteLine("*Name - {0}\n**Description - {1}\n**Is vegeterian - {2}\n**Price - {3}\n\n",
                    menuItem.Name, menuItem.Description, menuItem.IsVegeterian, menuItem.Price);
            }
        }
    }
}
