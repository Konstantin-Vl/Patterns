using System;
using System.Collections.Generic;
using System.Text;
using Command.Commands;

namespace Command
{
    public class RemoteControl
    {
        private readonly List<ICommand> _onCommands = new List<ICommand>();
        private readonly List<ICommand> _offCommands = new List<ICommand>();
        private ICommand _undoCommand;

        public void AddCommand(ICommand onCommand, ICommand offCommand)
        {
            _onCommands.Add(onCommand);
            _offCommands.Add(offCommand);
        }

        private bool IsIndexValid(int slot)
        {
            if (0 <= slot && _onCommands.Count > slot) return true;

            Console.WriteLine("Index is out of range");
            return false;
        }

        public void OnButtonWasPushed(int slot)
        {
            if (!IsIndexValid(slot)) return;

            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            if (!IsIndexValid(slot)) return;

            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            if (_undoCommand != null)
                _undoCommand.Undo();
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder("\n------- Remote control -------\n");
            for (var i = 0; i < _onCommands.Count; i++)
                stringBuilder.Append(string.Format("[slot {0} ] {1} : {2} : {3}\n\n\n", i, _onCommands[i].GetName(), _onCommands[i].GetClassName(), _offCommands[i].GetClassName()));

            return stringBuilder.ToString();
        }
    }
}
