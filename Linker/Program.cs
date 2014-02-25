using System;

namespace Linker
{
    /*Паттерн "Компоновщик"
     * обьединяет обьекты в древовидные структуры для предоставления иерархий "часть-целое"
     * Есть меню, у меня есть дочерние элементы, причем элемент меню может сам по себе быть другим меню, скажем десертами. Для того что не проверять каждый
     * узел какие операции для него доступны - использовали данынй паттерн. Определили абстрактный класс MenuComponent - все меню и элементы меню должны наследоваться
     * от него. Почему абстрактный класс - потому что мы даем таким образам дочерним классам по умолчанию использовать базовый функционал класса потомка.
     * Далее создали класс MenuItem - это элемент меню (унаследованный от класса MenuComponent). В нем переопределям нужные для данного класса методы, все осатальные
     * будут использоваться из базового класса. После этого создаем класс Menu (так же унаследованный от MenuComponent). Логика таже - переопределить нужные для данного
     * класса методы. Стоит обратить внимание на метод Print(). Так как данные класс Menu представляет собой набор элементов меню, при выводе на печать
     * нужно отображать не только название меню, но и сопутсвующую информацию у элементов меню. Для этого был использован паттерн "Итератор", т.е. проходим
     * по коллеции элентов для данного меню и вызываем метод Print() для каждого из них (стоит заметить, что любой из элементов меню может быть либо просто элементом
     * либо отдельным меню. Но какая именно реализация метода Print() будет вызванна - определяется за счет полиморфизма).
     * После этого наполняем меню и выводим на печать.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var allMenus = CreateMenu();
            var waitress = new Waitress(allMenus);

            waitress.PrintMenu();

            Console.ReadKey(true);
        }

        private static MenuComponent CreateMenu()
        {
            var pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            var dinnerMenu = new Menu("DINNER MENU", "Lunch");
            var cafeMenu = new Menu("CAFE MENU", "Dinner");
            var dessertMenu = new Menu("DESSERT MENU", "Dessert");

            var allMenus = new Menu("ALL MENUS", "All menus combined") { pancakeHouseMenu, dinnerMenu, cafeMenu };

            pancakeHouseMenu.Add(new MenuItem("Pancake1", "PancakeDescription1", true, 1));
            pancakeHouseMenu.Add(new MenuItem("Pancake2", "PancakeDescription2", true, 1.99));
            pancakeHouseMenu.Add(new MenuItem("Pancake3", "PancakeDescriptiob3", false, 4));

            cafeMenu.Add(new MenuItem("Caffe1", "CaffeDescription1", true, 56));
            cafeMenu.Add(new MenuItem("Caffe2", "CaffeDescription2", true, 66.32));

            dinnerMenu.Add(new MenuItem("Dinner1", "DinnerDescription1", false, 100));
            dinnerMenu.Add(new MenuItem("Dinner2", "DinnerDescription2", false, 12));
            dinnerMenu.Add(new MenuItem("Dinner3", "DinnerDescription3", true, 56.5));
            dinnerMenu.Add(new MenuItem("Dinner4", "DinnerDescription4", false, 2));
            dinnerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Dessert1", "DessertDescription1", false, 20));
            dessertMenu.Add(new MenuItem("Dessert2", "DessertDescription2", false, 15.6));
            dessertMenu.Add(new MenuItem("Dessert3", "DessertDescription3", true, 14.3));

            return allMenus;
        }
    }
}
