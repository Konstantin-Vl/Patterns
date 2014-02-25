using System;
using System.Collections;

namespace Linker
{
    public class Menu : MenuComponent, IEnumerable
    {
        private IEnumerator _enumerator;

        private readonly ArrayList _menuComponents = new ArrayList();
        private readonly string _name;
        private readonly string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent)_menuComponents[i];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.Write("\n{0}", GetName());
            Console.WriteLine(",  {0}", GetDescription());
            Console.WriteLine("-------------");

            var iterator = _menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                var menuComponent = (MenuComponent)iterator.Current;
                menuComponent.Print();
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return _enumerator ?? (_enumerator = new CompositeIterator(_menuComponents.GetEnumerator()));
        }
    }
}
