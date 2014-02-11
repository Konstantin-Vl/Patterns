using AbstractFactory.IngridientFactory;
using  AbstractFactory.Pizza;
namespace AbstractFactory
{
    public class NyPizzaStore : IPizzaStore
    {
        public Pizza.Pizza CreatePizza(PizzaType pizzaType)
        {
            var factory = new NyPizzaIngridientFactory();

            switch (pizzaType)
            {
                case PizzaType.NySimplePizza:
                    return new NySimplePizza(factory);
                default:
                    return new SimplePizza(factory);
            }
        }
    }
}
