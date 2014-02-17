using System;
using System.Collections.Generic;
using AbstractFactory.Ingridients;

namespace AbstractFactory.Pizza
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public List<Veggies> Veggieses { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Clam Clam { get; set; }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza");
        }
    }
}
