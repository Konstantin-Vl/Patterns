using System;

namespace Adapter
{
    public class MallarDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("I quack");
        }

        public void Fly()
        {
            Console.WriteLine("I fly");
        }
    }
}
