using System;
using Patterns.Fly;
using Patterns.Quack;

namespace Patterns.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new CoolQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I displays as MallardDuck");
        }
    }
}
