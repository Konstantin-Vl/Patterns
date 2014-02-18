using System;

namespace Singleton
{
    /*Паттерн "Одиночка"
     * Одиночка гарантирует, что класс имеет только один экземпляр и предоставляет глобальную точку доступа к этому экземляру.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var singelton1 = SingeltonSimple.GetInstanse();
            singelton1.SayHello();

            var singelton2 = SingeltonMultiThreadSafety.GetInstanse();
            singelton2.SayHello();

            Console.ReadKey(true);
        }
    }
}
