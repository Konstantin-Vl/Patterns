using System;

namespace SimpleFactory
{
    public class SimplePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare Simple pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake Simple pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut simple pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box Simple pizza");
        }
    }
}