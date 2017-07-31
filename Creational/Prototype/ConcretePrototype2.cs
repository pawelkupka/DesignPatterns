using System;

namespace Prototype
{
    public class ConcretePrototype2 : IPrototype
    {
        private readonly string _state;

        public ConcretePrototype2()
        {
            _state = "ConcretePrototype2";
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
