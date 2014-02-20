using System;

namespace Adapter
{
    /*Паттерн "Адаптер"
     * Преобразует интерфейс класса к другому интерфейсу, на который расчитан клиент. Адаптер обеспечивает совместную работу классов, невозможную при обычных
     * условиях из-за несовместимости интерфейсов.
     * Скажем мы хотим управлять нашими индюками так же как утками, но при этом мы не хотим измениять какой либо из этих классов. В этом случае применим данный
     * паттерн. Для начала создадим класс и наследуем его от интерфейса IDuck, а качестве параметра конструктора передадим обьект интерфейса ITurkey. Реализуем 
     * интерфейс IDuck таким образом как нам необходимо - при вызове метода Quack - вызовем метод Gobble интерфейса ITurkey, при вызове Fly - Fly интерфейса 
     * ITurkey. Вот и все. Все очень просто...
     */
    class Program
    {
        static void Main(string[] args)
        {
            var simpleDuck = new MallarDuck();
            simpleDuck.Quack();
            simpleDuck.Fly();
            Console.WriteLine("----------------------");

            var simpleTurkey = new WildTurkey();
            simpleTurkey.Gobble();
            simpleDuck.Fly();
            Console.WriteLine("----------------------");

            var muttant = new TurkeyAdapter(simpleTurkey);
            muttant.Quack();
            muttant.Fly();

            Console.ReadKey(true);
        }
    }
}
