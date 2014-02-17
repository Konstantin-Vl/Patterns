using System.Collections.Generic;
using AbstractFactory.Ingridients;
using AbstractFactory.Ingridients.Ny;

namespace AbstractFactory.IngridientFactory
{
    public class NyIngridientFactory : IIngridientFactory
    {
        public Dough CreateDoug()
        {
            return new NyDough();
        }

        public Sauce CreateSauce()
        {
            return new NySauce();
        }

        public Cheese CreateCheese()
        {
            return new NyCheese();
        }

        public List<Veggies> CreateVeggies()
        {
            return new List<Veggies> { new NyVeggies(), new NyVeggies() };
        }

        public Pepperoni CreatePepperoni()
        {
            return new NyPepperoni();
        }

        public Clam CreateClam()
        {
            return new NyClam();
        }
    }
}
