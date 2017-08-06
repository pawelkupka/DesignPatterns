using System;

namespace DesignPatterns.Structural.Adapter
{
    public class Adaptee
    {
        public void AdapteeMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
