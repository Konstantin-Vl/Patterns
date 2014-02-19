namespace Command.Commands.Stereo
{
    public class StereoOffWithCdCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }

        public string GetClassName()
        {
            return this.ToString();
        }

        public string GetName()
        {
            return _stereo.Name;
        }
    }
}
