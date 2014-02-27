using CompositePatterns.Gooses;

namespace CompositePatterns
{
    public class GooseAdapter:IQuackable
    {
        private readonly Goose _goose;

        
        private readonly Observable _observable;

        public GooseAdapter()
        {
            _observable = new Observable(this);
        }


        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void Quack()
        {
            _goose.Honk();
        }


        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}
