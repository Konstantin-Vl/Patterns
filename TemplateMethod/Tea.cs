using System;

namespace TemplateMethod
{
    public class Tea : CaffenieBeveraige
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Add some condiments to tea");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brew tea");
        }
    }
}
