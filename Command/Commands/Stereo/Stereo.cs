using System;

namespace Command.Commands.Stereo
{
    public class Stereo
    {
        public string Name { get; private set; }

        public Stereo(string name)
        {
            Name = name;
        }

        public void On()
        {
            Console.WriteLine("The stereo is turn on in {0}", Name);
        }

        public void SetCD()
        {
            Console.WriteLine("The CD is setted");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("The volume is setted as {0}", volume);
        }

        public void Off()
        {
            Console.WriteLine("The stereo is turned off in {0}",Name);
        }
    }
}
