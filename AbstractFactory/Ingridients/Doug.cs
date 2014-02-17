namespace AbstractFactory.Ingridients
{
    public class Dough : IIngridient
    {
        public string Name { get; set; }

        public Dough()
        {
            Name = "Dough";
        }
    }
}
