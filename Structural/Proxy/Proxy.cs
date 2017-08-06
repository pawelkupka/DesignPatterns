using System;

namespace DesignPatterns.Structural.Proxy
{
    public class Proxy : ISubject
    {
        private readonly ISubject _subject;
        private bool _isAuthenticated;

        public Proxy(ISubject subject)
        {
            _subject = subject;
            _isAuthenticated = false;
        }

        public void Authenticate()
        {
            _isAuthenticated = true;
        }

        public void Operation()
        {
            if (_isAuthenticated)
                _subject.Operation();
            else
                Console.WriteLine("Not authenticated");
        }
    }
}
