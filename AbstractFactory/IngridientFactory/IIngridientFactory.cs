using System.Collections.Generic;
using AbstractFactory.Ingridients;

namespace AbstractFactory.IngridientFactory
{
    public interface IIngridientFactory
    {
        Clam CreateClam();
        Dough CreateDough();
        Peperoni CreatePeperoni();
        Sauce CreateSauce();
        List<Vegie> CreateVegies();
    }
}
