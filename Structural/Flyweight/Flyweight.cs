using System;

namespace DesignPatterns.Structural.Flyweight
{
    public class Flyweight : IFlyweight
    {
        private readonly string _name;

        public Flyweight(string name)
        {
            _name = name;
        }

        public void Operation()
        {
            Console.WriteLine(_name);
        }
    }
}
