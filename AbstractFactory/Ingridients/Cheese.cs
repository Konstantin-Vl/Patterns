namespace AbstractFactory.Ingridients
{
    public class Cheese : IIngridient
    {
        public string Name { get; set; }

        public Cheese()
        {
            Name = "Cheese";
        }
    }
}
