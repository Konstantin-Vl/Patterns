using System;

namespace FactoryMethod
{
 public   class NyPeperonyPizza:IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Prepare peperony pizza like in NY");
        }

        public void Bake()
        {
           Console.WriteLine("Bake peperony pizza like in NY");
        }

        public void Cut()
        {
            Console.WriteLine("Cut peperony pizza like in NY");
        }

        public void Box()
        {
            Console.WriteLine("Box peperony pizza like in NY");
        }
    }
}
