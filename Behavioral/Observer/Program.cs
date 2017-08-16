namespace DesignPatterns.Behavioral.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Observer pattern has object, called the subject, which maintains a list of its dependents, called observers, 
            // and notifies them automatically of any state changes, usually by calling one of their methods.
            var observerA = new ObserverA();
            var observerB = new ObserverB();
            var subject = new Subject();
            subject.Register(observerA);
            subject.Register(observerB);
            subject.NotifyAll("A+B");
            subject.Unregister(observerA);
            subject.NotifyAll("B only");
        }
    }
}
