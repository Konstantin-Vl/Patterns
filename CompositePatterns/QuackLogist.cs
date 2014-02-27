using System;

namespace CompositePatterns
{
    public class QuackLogist:IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine("QuakLogist :{0} just qucked", duck);
        }
    }
}
