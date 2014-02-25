using System;
using System.Collections;

namespace Linker
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitress = new Waitress(new ArrayList { new PancakeHouseMenu(), new DinnerMenu(), new CaffeMenu() });
            waitress.PrintMenu();

            Console.ReadKey(true);
        }
    }
}
