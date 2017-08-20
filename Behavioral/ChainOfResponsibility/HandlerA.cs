using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class HandlerA : Handler
    {
        public HandlerA(Handler next) : base(next)  { }

        public override void HandleRequest()
        {
            Console.WriteLine("HandlerA");
            if (_next != null)
                _next.HandleRequest();
        }
    }
}
