namespace AbstractFactory.Ingridients
{
    public class Sauce
    {
        public string Name { get; protected set; }
        public double Cost { get; protected set; }

        public Sauce()
        {
            Name = "Sauce";
            Cost = 55;
        }
    }
}
