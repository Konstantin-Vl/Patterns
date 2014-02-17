using System;
using AbstractFactory.IngridientFactory;

namespace AbstractFactory.Pizza
{
    public class CheezePizza : Pizza
    {
        private readonly IIngridientFactory _ingridientFactory;

        public CheezePizza(IIngridientFactory ingridientFactory)
        {
            _ingridientFactory = ingridientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);

            Dough = _ingridientFactory.CreateDoug();
            Sauce = _ingridientFactory.CreateSauce();
            Cheese = _ingridientFactory.CreateCheese();
        }
    }
}
