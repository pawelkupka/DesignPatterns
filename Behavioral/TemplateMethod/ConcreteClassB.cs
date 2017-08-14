using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class ConcreteClassB : IPrimitives
    {
        public void Operation1()
        {
            Console.WriteLine("OperationB1");
        }

        public void Operation2()
        {
            Console.WriteLine("OperationB2");
        }
    }
}
