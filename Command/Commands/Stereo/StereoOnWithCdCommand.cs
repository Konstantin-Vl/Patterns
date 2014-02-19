namespace Command.Commands.Stereo
{
    public class StereoOnWithCdCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }

        public void Undo()
        {
            _stereo.Off();
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
