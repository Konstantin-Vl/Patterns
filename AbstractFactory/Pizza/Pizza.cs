using System;
using System.Collections.Generic;
using AbstractFactory.Ingridients;

namespace AbstractFactory.Pizza
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        protected Clam clam;
        protected Dough dough;
        protected Peperoni peperoni;
        protected Sauce sauce;
        protected List<Vegie> vegies;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 min");
        }

        public void Cut()
        {
            Console.WriteLine("Cut pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box the pizza");
        }
    }
}
