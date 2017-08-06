namespace DesignPatterns.Structural.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var implementationA = new ImplementationA();
            var implementationB = new ImplementationB(); 
            var abstraction = new Abstraction(implementationB); // This pattern decouples an abstraction from its implementation so that the two can vary independently
            abstraction.Operation();
        }
    }
}
