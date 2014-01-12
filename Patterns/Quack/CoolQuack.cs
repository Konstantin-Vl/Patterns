using System;

namespace Patterns.Quack
{
    public class CoolQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can CoolQuack");
        }
    }
}
