using System;

namespace Patterns.Fly
{
    class FlyWithWings:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can Fly");
        }
    }
}
