using System;

namespace DesignPatterns.Structural.Bridge
{
    public class ImplementationB : IBridge
    {
        public void OperationImp()
        {
            Console.WriteLine("ImplementationB");
        }
    }
}
