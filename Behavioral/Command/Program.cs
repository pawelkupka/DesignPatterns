namespace DesignPatterns.Behavioral.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Command design pattern encapsulates a request as an object, thereby allowing for the parameterization of clients with different requests, 
            // and the queuing or logging of requests
            var invoker = new Invoker();
            var receiver = new Receiver();
            var commandA = new CommandA(receiver);
            var commandB = new CommandB(receiver);

            invoker.Execute(commandA);
            invoker.Execute(commandB);
            invoker.Execute(commandA);
            invoker.Undo();
            invoker.Redo();
        }
    }
}
