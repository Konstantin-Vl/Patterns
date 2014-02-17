namespace AbstractFactory.Ingridients
{
    public class Sauce : IIngridient
    {
        public string Name { get; set; }

        public Sauce()
        {
            Name = "Sauce";
        }
    }
}
