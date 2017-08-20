using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Command
{
    public class Invoker
    {
        private readonly IList<ICommand> _commands;
        private int _current;

        public Invoker()
        {
            _commands = new List<ICommand>();
            _current = -1;
        }

        public void Execute(ICommand command)
        {
            _current = _current + 1;
            _commands.Add(command);
            _commands[_current].Execute();
        }

        public void Undo()
        {
            _current = _current - 1;
            _commands[_current].Execute();
        }

        public void Redo()
        {
            _current = _current + 1;
            _commands[_current].Execute();
        }
    }
}
