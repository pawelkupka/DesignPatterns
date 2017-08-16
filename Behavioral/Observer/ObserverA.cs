using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverA : IObserver
    {
        public void Notify(string message)
        {
            Console.WriteLine($"ObserverA: {message}");
        }
    }
}
