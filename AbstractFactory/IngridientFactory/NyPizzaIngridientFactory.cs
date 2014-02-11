using System.Collections.Generic;
using AbstractFactory.Ingridients;

namespace AbstractFactory.IngridientFactory
{
    public class NyPizzaIngridientFactory : IIngridientFactory
    {
        public Clam CreateClam()
        {
            return new NyClam();
        }

        public Dough CreateDough()
        {
            return new NyDough();
        }

        public Peperoni CreatePeperoni()
        {
            return new NyPeperony();
        }

        public Sauce CreateSauce()
        {
            return new Sauce();
        }

        public List<Vegie> CreateVegies()
        {
            return new List<Vegie> {new Vegie(), new Vegie(), new Vegie()};
        }
    }
}
