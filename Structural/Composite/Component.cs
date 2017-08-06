using System;

namespace DesignPatterns.Structural.Composite
{
    public class Component : IComponent
    {
        private readonly string _name;

        public Component(string name)
        {
            _name = name;
        }

        public IComponent Add(IComponent component)
        {
            throw new InvalidOperationException();
        }

        public IComponent Remove(IComponent component)
        {
            throw new InvalidOperationException();
        }

        public void Operation()
        {
            Console.WriteLine(_name);
        }
    }
}
