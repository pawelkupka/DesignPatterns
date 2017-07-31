using System;

namespace DesignPatterns.Creational.Prototype
{
    public class ConcretePrototype1 : IPrototype
    {
        private readonly string _state;

        public ConcretePrototype1()
        {
            _state = "ConcretePrototype1";
        }

        public IPrototype Clone()
        {
            return (IPrototype)MemberwiseClone();
        }

        public void DisplayState()
        {
            Console.WriteLine(_state);
        }
    }
}
