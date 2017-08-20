using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class HandlerB : Handler
    {
        public HandlerB(Handler next) : base(next) { }

        public override void HandleRequest()
        {
            Console.WriteLine("HandlerB");
            if (_next != null)
                _next.HandleRequest();
        }
    }
}
