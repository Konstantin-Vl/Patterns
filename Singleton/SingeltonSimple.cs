using System;

namespace Singleton
{
    public class SingeltonSimple
    {
        private static SingeltonSimple _uniqueInstanse;

        private SingeltonSimple(){ }

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
