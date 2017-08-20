using System;

namespace DesignPatterns.Behavioral.NullObject
{
    public abstract class Subject : ISubject
    {
        public static readonly ISubject Null = new NullSubject();

        public abstract void ShowMessage();

        private class NullSubject : Subject
        {
            public override void ShowMessage()
            {
                Console.WriteLine("NullSubject");
            }
        }
    }
}
