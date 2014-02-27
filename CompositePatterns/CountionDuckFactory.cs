using CompositePatterns.Ducks;

namespace CompositePatterns
{
    public class CountionDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            // Декоратор
            return new QuackCounter(new MallarDuck());
        }

        public override IQuackable CreateRedheadDuck()
        {
            // Декоратор
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackable CreateDuckCall()
        {
            // Декоратор
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable CreateRubberDuck()
        {
            // Декоратор
            return new QuackCounter(new RubberDuck());
        }
    }
}
