namespace AbstractFactory.Ingridients
{
    public class Veggies : IIngridient
    {
        public string Name { get; set; }

        public Veggies()
        {
            Name = "Veggies";
        }
    }
}
