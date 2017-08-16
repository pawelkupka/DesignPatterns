using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class Subject
    {
        private readonly IList<IObserver> _observers;

        public Subject()
        {
            _observers = new List<IObserver>();
        }

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyAll(string message)
        {
            foreach(var observer in _observers)
            {
                observer.Notify(message);
            }
        }
    }
}
