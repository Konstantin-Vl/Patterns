using AbstractFactory.IngridientFactory;
using AbstractFactory.Pizza;

namespace AbstractFactory.PizzaStore
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza.Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza.Pizza pizza = null;
            var ingridientFactory = new ChicagoIngridientFactory();
            
            switch (pizzaType)
            {
                case PizzaType.CheezePizza: pizza = new CheezePizza(ingridientFactory) { Name = "ChicagoCheezePizza" };
                    break;

                case PizzaType.ClamPizza: pizza = new ClamPizza(ingridientFactory) { Name = "ChicagoClamPizza" };
                    break;
            }
            return pizza;
        }
    }
}
