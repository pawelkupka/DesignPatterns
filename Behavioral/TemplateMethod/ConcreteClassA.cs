using System;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class ConcreteClassA : IPrimitives
    {
        public void Operation1()
        {
            Console.WriteLine("OperationA1");
        }

        public void Operation2()
        {
            Console.WriteLine("OperationA2");
        }
    }
}
