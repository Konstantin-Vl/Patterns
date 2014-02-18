using System;

namespace Singleton
{
    public sealed class SingeltonSimple
    {
        private static SingeltonSimple _uniqueInstanse;

        public static SingeltonSimple GetInstanse()
        {
            return _uniqueInstanse ?? (_uniqueInstanse = new SingeltonSimple());
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from SingeltonSimple");
        }
    }
}
