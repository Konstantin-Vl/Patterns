using System;
using CompositePatterns.Ducks;
using CompositePatterns.Gooses;

namespace CompositePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var duckFuctory = new CountionDuckFactory();

            Simulate(duckFuctory);

            Console.ReadKey(true);
        }

        private static void Simulate(AbstractDuckFactory duckFactory)
        {
            // Абстрактная фабрика
            var mallarDuck = duckFactory.CreateMallardDuck();
            var redheadDuck = duckFactory.CreateRedheadDuck();
            var duckCall = duckFactory.CreateDuckCall();
            var rubberDuck = duckFactory.CreateRubberDuck();
            
            // Компоновщик
            Console.WriteLine("Composite ducks to Flock");
            var flockOfDucks = new Flock();
            flockOfDucks.Add(mallarDuck);
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(duckCall);

            var flockOfMallards = new Flock();
            var mallardOne = duckFactory.CreateMallardDuck();
            var mallardTwo = duckFactory.CreateMallardDuck();
            var mallardThree = duckFactory.CreateMallardDuck();
            var mallardFour = duckFactory.CreateMallardDuck();
            flockOfMallards.Add(mallardOne);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardFour);

            flockOfDucks.Add(flockOfMallards);

            //Адаптер
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Simulate(mallarDuck);
            Simulate(redheadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            Console.WriteLine("\nWith Observer");
            var quackLogist = new QuackLogist();
            flockOfMallards.RegisterObserver(quackLogist);
            

            Console.WriteLine("\nAll flock");
            Simulate(flockOfDucks);

            Console.WriteLine("\nOnly mallards");
            Simulate(flockOfMallards);

            Console.WriteLine("\nThe ducks quacked: {0} times",QuackCounter.NumberOfQuacks);
        }

        private static void Simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
