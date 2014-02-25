namespace Iterator
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVegeterian { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string description, bool isVegeterian, double price)
        {
            Name = name;
            Description = description;
            IsVegeterian = isVegeterian;
            Price = price;
        }
    }
}