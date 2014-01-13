using System;
using Observer.Subjects;

namespace Observer.Observers
{
    public class AnoutherDisplay : IObserver, IDisplay
    {
        private int _temperature;
        private int _humidity;
        private int _pressure;
        private ISubject _subject;

        public AnoutherDisplay(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public void Update(int temperature, int humidity, int pressure)
        {
            _pressure = pressure;
            _humidity = humidity;
            _temperature = temperature;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("My name is {0}", GetType());
            Console.WriteLine("Pressure = {0}\nHumidity={1}\nTemperature={2}", _pressure, _humidity, _temperature);
        }
    }
}
