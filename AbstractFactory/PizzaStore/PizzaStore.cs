using System;

namespace AbstractFactory.PizzaStore
{
    public abstract class PizzaStore
    {
        public Pizza.Pizza OrderPizza(PizzaType pizzaType)
        {
            var pizza = CreatePizza(pizzaType);
            if (pizza == null)
            {
                Console.WriteLine("Pizza type is incorrect");
                return null;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza.Pizza CreatePizza(PizzaType pizzaType);
    }
}
