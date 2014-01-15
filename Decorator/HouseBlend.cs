namespace Decorator
{
    public class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            Description = "HouseBlend";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
