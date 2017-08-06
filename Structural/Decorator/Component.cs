using System;

namespace DesignPatterns.Structural.Decorator
{
    public class Component : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Component");
        }
    }
}
