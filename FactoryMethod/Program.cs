using System;

namespace FactoryMethod
{
    /*Паттерн "Фабричный метод"
     * Определяет интерфейс создания обьекта, но позволяет субклассам выбрать класс создаваемого объекта. Таким образом, фабричный метод делегирует операцию 
     * создания экземпляра субклассам.
     * Т.е что значит весь этот бред.
     * У нас есть базовый класс PizzaStore - он является абстрактым, и значит мы не можем использовать объекты его типа. Стоит отметить, что у него есть два метода
     * OrderPizza и CreatePizza - при этом CreatePizza является абстрактым. А это значит, что все дочерние классы класса PizzaStore должны предоставить собсвенную
     * реализацию данного метода - это и есть наш фабричный метод.
     * Ну а дальше все просто - создаем нужные классы, наследуем их от PizzaStore и реализуем данный метод как нам необходимо для каждого класса. И все
     * Теперь логика для заказа пиццы (OrderPizza) - одинакова для всех дочерних классов, а логика изготовления пиццы (CreatePizza) - зависит от конкретной реализации
     * данного метода
     */
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Joe wants peperony pizza like in NY");
            var nyPizzaStore = new NyPizzaStore();
            nyPizzaStore.OrderPizza(PizzaType.Peperony);
            Console.WriteLine("**********************************");

            Console.WriteLine("Sammy wanst peperony pizza like in Chicago and one simple pizza");
            var chicagoPizzaStore = new ChicagoPizzaStore();
            chicagoPizzaStore.OrderPizza(PizzaType.Peperony);
            chicagoPizzaStore.OrderPizza(PizzaType.SimplePizza);

            Console.ReadKey(true);
        }
    }
}
