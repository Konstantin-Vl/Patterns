using System.Collections.Generic;
using AbstractFactory.Ingridients;

namespace AbstractFactory.IngridientFactory
{
    public interface IIngridientFactory
    {
        Dough CreateDoug();
        Sauce CreateSauce();
        Cheese CreateCheese();
        List<Veggies> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clam CreateClam();
    }
}
