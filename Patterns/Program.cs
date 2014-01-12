using System;
using Patterns.Ducks;
using Patterns.Fly;
using Patterns.Quack;

namespace Patterns
{

    /* Паттерн "Стратегия"
     * Определяет семейство алгоритмов, инкапсулирует каждый из них и обеспечивает из взаимозаменяемость,
     * Он позволяет модифицировать алгоритмы независимо от их использования на стороне клиента.
     * 
     * Самое главное - определили два интерфейса IFlyBehavior и IQuackBehavior. Эти интерфейсы реализуюстся
     * соответсвующими классами, с помощью которых мы и будем задавать поведение для уток. Т.е., к примеру,
     * разные типы уток могут летать, а могут и не летать. Есть интерфейс IFlyBehavior, который говорит что утка
     * может вызвать метод Fly. И есть два класса - FlyWithWings и FlyNoWay. Каждый из низ реализует интерфейс
     * IFlyBehavior и реальизует метод Fly по свойму ( может утка летать или нет)
     * Затем в базовом абстактном классе Duck есть переменные типа IFlyBehavior и IQuackBehavior и методы, PerformFly()
     * и PerformQuack(), которые вызывают методы Fly() и Quack у переменных типа IFlyBehavior и IQuackBehavior.
     * После этого мы можем создавать уток и задавать им нужное нам поведение. Для этого создаем класс (к примеру
     * MallardDuck) и наследуем его от абстрактного класса Duck, и в конструкторе этого класса переменным типа 
     * IFlyBehavior и IQuackBehavior присваивам соответсвующие классы (к примеру new FlyWithWings) - тем самым
     * задавая поведение для нашей утки. Вот и все
     */



    class Program
    {
        static void Main(string[] args)
        {
            var duck1 = new MallardDuck();
            var duck2 = new ModelDuck();

            duck1.Display();
            duck1.PerformFly();
            duck1.PerformQuack();

            duck2.Display();
            duck2.PerformFly();
            duck2.PerformQuack();

            duck2.SetFlyBegavior(new FlyWithWings());
            duck2.SetQuackBehavior(new Squek());
            duck2.Display();
            duck2.PerformFly();
            duck2.PerformQuack();

            Console.ReadKey(true);
        }
    }
}
