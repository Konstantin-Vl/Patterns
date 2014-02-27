using System.Collections.Generic;

namespace CompositePatterns
{
    //Наблюдатель
    //Вспомогательный класс - для того чтобы не реализовывать данный функционал в каждом классе - наблюдателе
    public class Observable : IQuackObservable
    {
        private readonly IQuackObservable _duck;
        private readonly List<IObserver> _observers = new List<IObserver>();

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            //Итератор
            var enumerator = _observers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var observer = enumerator.Current;
                if (observer != null) observer.Update(_duck);
            }
        }
    }
}
