using System;

namespace FactoryMethod
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(PizzaType pizzaType)
        {
            var pizza = CreatePizza(pizzaType);

            if (pizza == null)
            {
                Console.WriteLine("Undefined type if pizza!!!");
                return null;
            }
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract IPizza CreatePizza(PizzaType pizzaType);
    }
}
