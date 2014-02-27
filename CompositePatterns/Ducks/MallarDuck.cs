using System;

namespace CompositePatterns.Ducks
{
    public class MallarDuck:IQuackable
    {
        private readonly Observable _observable;

        public MallarDuck()
        {
            _observable = new Observable(this);
        }
        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
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
