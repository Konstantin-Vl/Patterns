using System;

namespace FactoryMethod
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override IPizza CreatePizza(PizzaType pizzaType)
        {
            IPizza pizza = null;
            switch (pizzaType)
            {
                case PizzaType.CheezePizza:
                    pizza = new CheezePizza();
                    break;
                case PizzaType.SimplePizza:
                    pizza = new SimplePizza();
                    break;
                case PizzaType.Peperony:
                    pizza = new ChicagoPeperonyPizza();
                    break;
            }
            return pizza;
        }
    }
}
