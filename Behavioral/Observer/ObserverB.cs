using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverB : IObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"ObserverB: {message}");
        }
    }
}
