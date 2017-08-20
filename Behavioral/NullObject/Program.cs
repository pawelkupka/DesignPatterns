namespace DesignPatterns.Behavioral.NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // NullObject design pattern allows avoid null references by providing a default object
            var concreteSubject = new ConcreteSubject();
            var nullSubject = Subject.Null;
            concreteSubject.ShowMessage();
            nullSubject.ShowMessage();
        }
    }
}
