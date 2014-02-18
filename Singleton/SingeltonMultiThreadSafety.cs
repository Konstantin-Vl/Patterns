using System;

namespace Singleton
{
    public sealed class SingeltonMultiThreadSafety
    {
        private static volatile SingeltonMultiThreadSafety _uniqueInstanse;
        private static readonly object SyncRoot = new object();

        public static SingeltonMultiThreadSafety GetInstanse()
        {
            if (_uniqueInstanse != null) return _uniqueInstanse;
            
            lock (SyncRoot)
            {
                if(_uniqueInstanse == null)
                    _uniqueInstanse = new SingeltonMultiThreadSafety();
            }
            return _uniqueInstanse;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from SingeltonMultiThreadSafety");
        }
    }
}
