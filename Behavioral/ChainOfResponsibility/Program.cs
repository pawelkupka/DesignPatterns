using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chain of responsibility pattern allows more than one object to handle the request. 
            var handlerB = new HandlerB(null);
            var handlerA = new HandlerA(handlerB);

            handlerA.HandleRequest();
        }
    }
}
