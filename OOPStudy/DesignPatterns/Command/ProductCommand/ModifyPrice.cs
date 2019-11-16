using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ModifyPrice
    {
        private readonly List<ICommand> _commandsHistoryStore;
        private ICommand _command;

        public ModifyPrice()
        {
            _commandsHistoryStore = new List<ICommand>();
        }

        public void SetCommand(ICommand command) => _command = command;

        public void Invoke()
        {
            _commandsHistoryStore.Add(_command);
            _command.ExecuteAction();
        }

        public void Undo()
        {
            var lastCommandIndex = _commandsHistoryStore.Count - 1;
            _commandsHistoryStore.RemoveAt(lastCommandIndex);
            var lastCommand = _commandsHistoryStore.ElementAt(lastCommandIndex);
            lastCommand.UndoAction();
        }

        public void UndoActions()
        {
            foreach (var command in Enumerable.Reverse(_commandsHistoryStore))
            {
                command.UndoAction();
            }
        }
    }
}
