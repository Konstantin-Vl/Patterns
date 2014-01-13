using System.Collections.Generic;
using Observer.Observers;

namespace Observer.Subjects
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private int _temperature, _humidity, _pressure;

        public void RegisterObserver(IObserver observer)
        {
            if (!_observers.Exists(c => c == observer))
                _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (_observers.Exists(c => c == observer))
                _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(c => c.Update(_temperature, _humidity, _pressure));
        }

        public void MeasurmentsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurments(int temperature, int humidity, int pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MeasurmentsChanged();
        }
    }
}
