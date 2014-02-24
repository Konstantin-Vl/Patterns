using System;

namespace TemplateMethod
{
    public class CoffeaWitMilk : CaffenieBeveraige
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Add few condiments to coffee with milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brew coffee with milk");
        }
    }
}
