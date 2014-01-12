using System;

namespace Patterns.Quack
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can't quac");
        }
    }
}
