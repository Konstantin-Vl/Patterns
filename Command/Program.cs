using System;
using System.Collections.Generic;
using Command.Commands;
using Command.Commands.Light;
using Command.Commands.Stereo;

namespace Command
{
    class Program
    {
        /*Паттерн "Комманда"
         * Инкапсулирует запрос в виде объекта, делая возможной параметризацию клиентских объектов с другими запросами, организацию очереди или регистрацию запросов,
         * а также поддержку отмены операций
         * Самой главное - мы не знаем что за операции у нас есть, как они работаю - но мы можем их спокойной вызвать. Для этого есть у нас базовый интерфейс
         * ICommand - у которого есть метод Execute. И скажем у нас есть обьект Light, в котором инкапсулированна логика работы со светом в какой-то комнате.
         * Мы создаем класс по включению света - LightOnCommand, в котором реализуем интерфейс ICommand. И в методе Execute будет вызывать метод класса Light On().
         * Далее создадим общий класс для управления всеми возможными командами RemoteControl. Вот и все. Чтобы иметь возможность включать свет мы созадим объект 
         * класса Light, создадим объект класса LightOnCommand, указав в качестве параметра конструктора созданный ранее объект класа Light и добавим этот
         * объект в коллекцию команд объекта класса RemoteControl. Вот и все. Еще раз - самое важное что наш клиент(RemoteControl) ничего не знает о том, как и кто
         * будет исполнять его желания (включить свет)
         */
        static void Main(string[] args)
        {
            var remoteControl = new RemoteControl();

            //Создаем наши объекты
            var livingRoomLight = new Light("Living room");
            var kitchenLight = new Light("Kithen");
            var stereo = new Stereo("Living room");

            //Создаем для каждого объекты его команды для управления
            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);

            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);

            var stereOn = new StereoOnWithCdCommand(stereo);
            var stereoOff = new StereoOffWithCdCommand(stereo);

            // Добавляем комманды в наш контроллер
            remoteControl.AddCommand(livingRoomLightOn,livingRoomLightOff);
            remoteControl.AddCommand(kitchenLightOn,kitchenLightOff);
            remoteControl.AddCommand(stereOn,stereoOff);

            Console.WriteLine(remoteControl);

            //Вызыввем их
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(2);
           
            //Отмена последней команды
            remoteControl.UndoButtonWasPushed();

            //Набор комманд
            var macroCommandOn = new MacroCommand(new List<ICommand> {livingRoomLightOn, kitchenLightOff, stereOn});
            var macroCommandOff = new MacroCommand(new List<ICommand> { livingRoomLightOff, kitchenLightOn, stereoOff });
            remoteControl.AddCommand(macroCommandOn, macroCommandOff);
            
            Console.WriteLine("I run macros");
            remoteControl.OnButtonWasPushed(3);

            Console.ReadKey(true);
        }
    }
}
