using System.Collections.Generic;
using System.Text;

namespace Command.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> _commands;

        public MacroCommand(List<ICommand> commands )
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var command in _commands)
                command.Execute();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }

        public string GetClassName()
        {
            var stringBuilder = new StringBuilder();
            foreach (var command in _commands)
                stringBuilder.Append(string.Format(" --- {0}\n", command.GetClassName()));
            return stringBuilder.ToString();
        }

        public string GetName()
        {
            var stringBuilder = new StringBuilder();
            foreach (var command in _commands)
                stringBuilder.Append(string.Format(" --- {0}\n", command.GetName()));
            return stringBuilder.ToString();
        }
    }
}
