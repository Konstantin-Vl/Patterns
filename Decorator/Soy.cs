namespace Decorator
{
    public class Soy : Beverage
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return 0.23 + _beverage.Cost();
        }
    }
}
