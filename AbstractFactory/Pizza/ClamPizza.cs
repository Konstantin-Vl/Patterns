using System;
using AbstractFactory.IngridientFactory;

namespace AbstractFactory.Pizza
{
    public class ClamPizza : Pizza
    {
        private readonly IIngridientFactory _ingridientFactory;

        public ClamPizza(IIngridientFactory ingridientFactory)
        {
            _ingridientFactory = ingridientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Dough = _ingridientFactory.CreateDoug();
            Sauce = _ingridientFactory.CreateSauce();
            Cheese = _ingridientFactory.CreateCheese();
            Clam = _ingridientFactory.CreateClam();
        }
    }
}
