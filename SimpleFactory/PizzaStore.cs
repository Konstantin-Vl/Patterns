using System;

namespace SimpleFactory
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public IPizza OrderPizza(PizzaType type)
        {
            var pizza = _factory.CreatePizza(type);
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
    }
}
