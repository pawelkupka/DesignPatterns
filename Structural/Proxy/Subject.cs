using System;

namespace DesignPatterns.Structural.Proxy
{
    public class Subject : ISubject
    {
        public void Operation()
        {
            Console.WriteLine("Subject.Request");
        }
    }
}
