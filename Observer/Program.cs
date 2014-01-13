using System;
using Observer.Observers;
using Observer.Subjects;

namespace Observer
{
    /*Паттерн "Наблюдатель"
     Определяет отношение "один-ко-многим" между объектами таким образом, что при изменении состояния
     * одного объекта происходит оповещение всех зависимых объектов
     * В данном  случае есть два интерфейса: ISubject - интерфейс для субьекта и IObserver - интерфейс для наблюдателя
     * В качестве субьекта в данном случае выступает класс WeatherData, который реализует интрефейс ISubject.
     * Он умеет регистрировать наблюдателей, исключать объект из числа наблюдателей и оповещать своих наблюдателей
     * о том, что у него произошли какие-то изменения - в данном случае изменились значение погоды
     * В свою очеред, классы CurrentConditionDisplay и AnotherDisplay - являются наблюдателями - так как они 
     * реализуют интерфейс IObserver и они зарегестрировались в качестве наблюдателей у класса WeatherData
     * Как только в классе WeatherData изменятся определенные переменные - все наблюдатели данного класса 
     * будут оповещенны
     */
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var observer1 = new CurrentConditionDisplay(weatherData);
            var observer2 = new CurrentConditionDisplay(weatherData);
            var observer3 = new AnoutherDisplay(weatherData);

            weatherData.SetMeasurments(1,2,3);
            weatherData.SetMeasurments(55,66,77);
            
            Console.WriteLine("One of objects is not observer");
            weatherData.RemoveObserver(observer2);

            weatherData.SetMeasurments(100,200,300);
            Console.ReadKey(true);
        }
    }
}
