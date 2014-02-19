namespace Command.Commands.Light
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }

        public string GetClassName()
        {
            return this.ToString();
        }

        public string GetName()
        {
            return _light.Name;
        }
    }
}
