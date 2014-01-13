namespace Observer.Observers
{
    public interface IObserver
    {
        void Update(int temperature, int humidity, int pressure);
    }
}
