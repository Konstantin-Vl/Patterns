using System.Collections.Generic;
using AbstractFactory.Ingridients;
using AbstractFactory.Ingridients.Chicago;

namespace AbstractFactory.IngridientFactory
{
    public class ChicagoIngridientFactory : IIngridientFactory
    {
        public Dough CreateDoug()
        {
            return new ChicagoDough();
        }

        public Sauce CreateSauce()
        {
            return new ChicagoSauce();
        }

        public Cheese CreateCheese()
        {
            return new ChicagoCheese();
        }

        public List<Veggies> CreateVeggies()
        {
            return new List<Veggies> { new ChicagoVeggies(), new ChicagoVeggies() };
        }

        public Pepperoni CreatePepperoni()
        {
            return new ChicagoPepperoni();
        }

        public Clam CreateClam()
        {
            return new ChicagoClam();
        }
    }
}
