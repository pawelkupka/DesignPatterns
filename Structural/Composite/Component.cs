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

        public void Operation()
        {
            Console.WriteLine(_name);
        }
    }
}
