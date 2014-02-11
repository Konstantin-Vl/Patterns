using System.Collections.Specialized;

namespace AbstractFactory.Ingridients
{
    public class Dough
    {
        public  string Name { get; protected set; }
        public  double Cost { get; protected set; }
    }

    public class NyDough:Dough
    {
        public NyDough()
        {
            Name = "NY Dough";
            Cost = 25;
        }
    }

    public class ChicagoDough : Dough
    {
        public ChicagoDough()
        {
            Name = "Chicago Dough";
            Cost = 12;
        }
    }
}
