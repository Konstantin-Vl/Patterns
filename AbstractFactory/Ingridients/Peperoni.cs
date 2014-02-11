namespace AbstractFactory.Ingridients
{
    public class Peperoni
    {
        public string Name { get; protected set; }
        public double Cost { get; protected set; }
    }

    public class NyPeperony : Peperoni
    {
        public NyPeperony()
        {
            Name = "NY Peperoni";
            Cost = 12;
        }
    }

    public class ChicacogoPeperony : Peperoni
    {
        public ChicacogoPeperony()
        {
            Name =  "Chicago Peperoni";
            Cost = 122;
        }
    }
}
