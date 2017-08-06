using System;

namespace DesignPatterns.Structural.Decorator
{
    public class Decorator : IComponent
    {
        private readonly IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public void Operation()
        {
            Console.WriteLine("=== Decoration ===");
            _component.Operation();
        }
    }
}
