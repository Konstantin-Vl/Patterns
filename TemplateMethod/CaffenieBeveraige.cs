using System;

namespace TemplateMethod
{
    public abstract class CaffenieBeveraige
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void AddCondiments();

        protected void PourInCup()
        {
            Console.WriteLine("Pour in cup");
        }

        protected abstract void Brew();

        protected void BoilWater()
        {
            Console.WriteLine("Boil water");
        }
    }
}
