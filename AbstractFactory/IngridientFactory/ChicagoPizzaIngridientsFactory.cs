using System.Collections.Generic;
using AbstractFactory.Ingridients;

namespace AbstractFactory.IngridientFactory
{
    public class ChicagoPizzaIngridientsFactory : IIngridientFactory
    {
        public Clam CreateClam()
        {
            return new ChicagoClam();
        }

        public Dough CreateDough()
        {
            return new ChicagoDough();
        }

        public Peperoni CreatePeperoni()
        {
            return new ChicacogoPeperony();
        }

        public Sauce CreateSauce()
        {
            return new Sauce();
        }

        public List<Vegie> CreateVegies()
        {
            return new List<Vegie> {new Vegie()};
        }
    }
}
