using System;

namespace Patterns.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't Fly");
        }
    }
}
