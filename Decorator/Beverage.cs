namespace Decorator
{
    public abstract class Beverage
    {
        protected string Description = "Unknown description";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
