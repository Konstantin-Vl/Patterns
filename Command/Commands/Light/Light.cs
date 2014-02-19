using System;

namespace Command.Commands.Light
{
    public class Light
    {
        public string Name { get; private set; }

        public Light(string name)
        {
            Name = name;
        }

        public void On()
        {
            Console.WriteLine("The light is turn on in {0}", Name);
        }

        public void Off()
        {
            Console.WriteLine("The light is turn off in {0}", Name);
        }
    }
}
