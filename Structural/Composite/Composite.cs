using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    public class Composite : IComponent
    {
        private readonly string _name;
        private readonly IList<IComponent> _components;

        public Composite(string name)
        {
            _name = name;
            _components = new List<IComponent>();
        }

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IComponent component)
        {
            _components.Remove(component);
        }

        public void Operation()
        {
            Console.WriteLine(_name);
            foreach (var child in _components)
                child.Operation();
        }
    }
}
