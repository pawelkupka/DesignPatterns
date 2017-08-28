namespace DesignPatterns.Behavioral.Servant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Servant is a class whose provides methods that take care of a desired service, 
            // while objects for which the servant does something, are taken as parameters.
            var servant = new Servant();
            var serviceA = new ServiceA();
            var serviceB = new ServiceB();

            servant.DisplayMessage(serviceA, "ServiceA");
            servant.DisplayMessage(serviceB, "ServiceB");
        }
    }
}
