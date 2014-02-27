using System;

namespace CompositePatterns.Ducks
{
    public class DuckCall:IQuackable
    {
        private readonly Observable _observable;

        public DuckCall()
        {
            _observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Kwak");
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
