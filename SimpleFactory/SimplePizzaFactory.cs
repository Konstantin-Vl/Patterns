namespace SimpleFactory
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(PizzaType type)
        {
            IPizza pizza = null;

            switch (type)
            {
                    case PizzaType.CheezePizza:
                    pizza = new CheezePizza();
                    break;
                    case  PizzaType.SimplePizza:
                    pizza = new SimplePizza();
                    break;
            }

            return pizza;
        }
    }
}