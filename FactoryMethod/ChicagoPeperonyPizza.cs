using System;

namespace FactoryMethod
{
    public class ChicagoPeperonyPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare peperony pizza like in Chicago");
        }

        public void Bake()
        {
            Console.WriteLine("Bake peperony pizza like in Chicago");
        }

        public void Cut()
        {
            Console.WriteLine("Cut peperony pizza like in Chicago");
        }

        public void Box()
        {
            Console.WriteLine("Box peperony pizza like in Chicago");
        }
    }
}
