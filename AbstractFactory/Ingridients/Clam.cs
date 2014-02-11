namespace AbstractFactory.Ingridients
{
    public class Clam
    {
        public string Name { get; protected set; }
        public double Cost { get; protected set; }
    }

    public class NyClam : Clam
    {
        public NyClam()
        {
            Name = "NY Clam";
            Cost = 99;
        }
    }

    public class ChicagoClam : Clam
    {
        public ChicagoClam()
        {
            Name = "NY Clam";
            Cost = 99;
        }
    }
}
