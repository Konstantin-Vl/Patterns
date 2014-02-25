using System;
using System.Collections;

namespace Linker
{
    public class MenuItem:MenuComponent, IEnumerable
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _isVegeterian;
        private readonly double _price;

        public MenuItem(string name, string description, bool isVegeterian, double price)
        {
            _name = name;
            _description = description;
            _isVegeterian = isVegeterian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override bool IsVegeterian()
        {
            return _isVegeterian;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override void Print()
        {
            Console.Write("   {0}",GetName());
            if(IsVegeterian())
                Console.Write("v");
            Console.WriteLine(", {0} ",GetPrice());
            Console.WriteLine("   -- {0}",GetDescription());
        }

        public override IEnumerator GetEnumerator()
        {
            return new NullIterator();
        }
    }
}