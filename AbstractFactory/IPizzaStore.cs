
namespace AbstractFactory
{
    public interface IPizzaStore
    {
        Pizza.Pizza CreatePizza(PizzaType pizzaType);
    }
}
