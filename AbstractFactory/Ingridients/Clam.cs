namespace AbstractFactory.Ingridients
{
    public class Clam : IIngridient
    {
        public string Name { get; set; }

        public Clam()
        {
            Name = "Clam";
        }
    }
}
