using Observer.Observers;

namespace Observer.Subjects
{
   public interface ISubject
   {
       void RegisterObserver(IObserver observer);
       void RemoveObserver(IObserver observer);
       void NotifyObservers();
   }
}
