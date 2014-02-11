namespace AbstractFactory.Ingridients
{
    public class Vegie
    {
        public string Name { get; protected set; }
        public double Cost { get; protected set; }

        public Vegie()
        {
            Name = "Vegie";
            Cost = 12;
        }
    }
}
