using System;

namespace DesignPatterns.Behavioral.Servant
{
    public class ServiceB : IService
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
