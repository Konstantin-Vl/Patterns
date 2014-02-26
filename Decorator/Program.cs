using System;

namespace Decorator
{
    /*Паттерн "Декоратор"
     *динамически наделяет объект новыми возмоностями, и является гибкой альтернативой наследованию в области расширения
     * функциональности
     * 
     * Сначала определили абстрактый класс Beberage  - от него наследуем все класссы, но не для того чтобы только
     * получить какие то функции и поля, но чтобы можно было приводить классы к одному типу. После этого
     * у данного класса мы пометили функцию Cost() как абстрактую - дочерний класс обязан предоставить собственную
     * реализацию и функцию GetDescription - пометили ее как virtual -дочерний класс способен решить будет ли
     * он использовать реализацию базового класса или предоставит свою. У классов дополнений - есть поле типа Beverage
     * в котором хранится ссылка на предыдущий класс (класс который мы "завернули" в наш текущий класс). Так как 
     * завернутый класс и класс обертка одного типа то мы спокойно получим метод Cost
     * Вот и все. Тем самым мы закрыли классы для изменения кода, но открыли для расширения - чтобы добавить новую
     * функциональность мы декорируем класс, а не переписываем его
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'd like one expresso");
            Beverage beverage1 = new Expresso();
            PrintBeverageInfo(beverage1);

            Console.WriteLine("I'd like one expresso with two mocha");
            Beverage beverage2 = new Expresso();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            PrintBeverageInfo(beverage2);

            Console.WriteLine("I'd like one houseblend with one mocha and one soy");
            Beverage beverage3 = new HouseBlend();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Soy(beverage3);
            PrintBeverageInfo(beverage3);

            Console.ReadKey(true);
        }

        private static void PrintBeverageInfo(Beverage beverage)
        {
            Console.WriteLine("Name: {0}, cost = {1}",beverage.GetDescription(), beverage.Cost());
        }
    }
}
