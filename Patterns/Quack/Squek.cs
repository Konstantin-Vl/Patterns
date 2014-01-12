using System;

namespace Patterns.Quack
{
    public class Squek : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can squek");
        }
    }
}
