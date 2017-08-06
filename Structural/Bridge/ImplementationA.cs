using System;

namespace DesignPatterns.Structural.Bridge
{
    public class ImplementationA : IBridge
    {
        public void OperationImp()
        {
            Console.WriteLine("ImplementationA");
        }
    }
}
