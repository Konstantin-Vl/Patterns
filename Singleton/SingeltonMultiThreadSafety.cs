using System;

namespace Singleton
{
    public class SingeltonMultiThreadSafety
    {
        private static volatile SingeltonMultiThreadSafety _uniqueInstanse;
        private static readonly object SyncRoot = new object();

        private SingeltonMultiThreadSafety()
        {
        }

        public static SingeltonMultiThreadSafety GetInstanse()
        {
            if (_uniqueInstanse != null) return _uniqueInstanse;

            lock (SyncRoot)
            {
                if (_uniqueInstanse == null)
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
