using System.Collections.Generic;

namespace CompositePatterns
{
    //Компоновщик
    public class Flock : IQuackable
    {
        private readonly List<IQuackable> _quakers = new List<IQuackable>();
        private readonly Observable _observable;

        public Flock()
        {
            _observable = new Observable(this);
        }


        public void Add(IQuackable quaker)
        {
            _quakers.Add(quaker);
        }

        public void Quack()
        {
            // Итератор
            var enumerator = _quakers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var quaker = enumerator.Current;
                if (quaker != null)
                    quaker.Quack();
            }
        }


        public void RegisterObserver(IObserver observer)
        {
            // Итератор
            var enumerator = _quakers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var quaker = enumerator.Current;
                if (quaker != null) 
                    quaker.RegisterObserver(observer);
            }
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}
