using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new NyPizzaStore();
            pizzaStore.CreatePizza(PizzaType.NySimplePizza);

            Console.ReadKey(true);
        }
    }
}
