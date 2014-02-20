using System;

namespace Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("I gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I fly");
        }
    }
}
