using System;

namespace DesignPatterns.Behavioral.Servant
{
    public class ServiceA : IService
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
