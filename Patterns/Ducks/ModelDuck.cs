using System;
using Patterns.Fly;
using Patterns.Quack;

namespace Patterns.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I displays as ModelDuck");
        }
    }
}
