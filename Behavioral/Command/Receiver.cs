using System;

namespace DesignPatterns.Behavioral.Command
{
    public class Receiver
    {
        public void Action(string value)
        {
            Console.WriteLine(value);
        }
    }
}
