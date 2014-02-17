using AbstractFactory.IngridientFactory;
using AbstractFactory.Pizza;

namespace AbstractFactory.PizzaStore
{
    public class NyPizzaStore : PizzaStore
    {
        protected override Pizza.Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza.Pizza pizza = null;

            var pizzaIngridientFactory = new NyIngridientFactory();

            switch (pizzaType)
            {
                case PizzaType.CheezePizza:
                    pizza = new CheezePizza(pizzaIngridientFactory) {Name = "NyCheezePizza"};
                    break;

                case PizzaType.ClamPizza:
                    pizza = new ClamPizza(pizzaIngridientFactory){Name = "NyClamPizza"};
                    break;
            }

            return pizza;
        }
    }
}
