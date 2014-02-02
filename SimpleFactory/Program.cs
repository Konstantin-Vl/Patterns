using System;

namespace SimpleFactory
{

    /* Простая Фабрика
     * На самом деле простая фабрика не является паттерном проектирования - это скорее всего идиома программирования
     * Самое главное, что тут мы вынесли код, создающий конкретный объект (пиццу) в отдельный класс SimplePizzaFactory
     * Таким образом, в дальнейшем, когда появятся новые виды пицц - нужно будет произвести изменения лишь в одном 
     * месте - в этом классе, добавив создание нужного экземляра
     */
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new PizzaStore(new SimplePizzaFactory());
            
            Console.WriteLine("I'd like one Cheeze pizza");
            pizzaStore.OrderPizza(PizzaType.CheezePizza);

            Console.WriteLine("I'd like one Cheeze pizza and one Simple pizza");
            pizzaStore.OrderPizza(PizzaType.CheezePizza);
            pizzaStore.OrderPizza(PizzaType.SimplePizza);

            Console.ReadKey(true);
        }
    }
}
