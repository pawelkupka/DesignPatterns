using System;

namespace DesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        private string _state;

        public Originator(string state)
        {
            _state = state;
        }

        public void ChangeState(string state)
        {
            _state = state;
        }

        public void ShowState()
        {
            Console.WriteLine(_state);
        }

        public Memento Save()
        {
            return new Memento(_state);
        }

        public void Restore(Memento memento)
        {
            _state = memento.State;
        }
    }
}
