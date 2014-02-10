namespace FactoryMethod
{
    public class NyPizzaStore : PizzaStore
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
                    pizza = new NyPeperonyPizza();
                    break;
            }
            return pizza;
        }
    }
}
