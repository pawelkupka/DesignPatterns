using System;

namespace DesignPatterns.Behavioral.NullObject
{
    public class ConcreteSubject : ISubject
    {
        public void ShowMessage()
        {
            Console.WriteLine("ConcreteSubject");
        }
    }
}
