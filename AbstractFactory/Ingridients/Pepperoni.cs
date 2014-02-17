namespace AbstractFactory.Ingridients
{
    public class Pepperoni : IIngridient
    {
        public string Name { get; set; }

        public Pepperoni()
        {
            Name = "Pepperoni";
        }
    }
}
