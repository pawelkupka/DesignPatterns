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

        public IComponent Add(IComponent component)
        {
            _components.Add(component);
            return this;
        }

        public IComponent Remove(IComponent component)
        {
            _components.Remove(component);
            return this;
        }

        public IList<IComponent> GetChildren()
        {
            return _components;
        }

        public void Operation()
        {
            Console.WriteLine(_name);
            var children = GetChildren();
            foreach (var child in children)
                child.Operation();
        }
    }
}
