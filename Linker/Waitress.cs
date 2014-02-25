using System;

namespace Linker
{
    public class Waitress
    {
        private readonly MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegeterianMenu()
        {
            var enumerator = _allMenus.GetEnumerator();
            Console.WriteLine("\nVEGETERIAN MENU\n------");
            while (enumerator.MoveNext())
            {
                var menuComponent = (MenuComponent)enumerator.Current;
                try
                {
                    if (menuComponent.IsVegeterian())
                        menuComponent.Print();
                }
                catch
                {
                }
            }
        }
    }
}
