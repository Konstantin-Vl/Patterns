using System;

namespace SimpleFactory
{
    public class CheezePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare Cheeze pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Bake Cheeze pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut Cheeze pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box Cheeze pizza");
        }
    }
}