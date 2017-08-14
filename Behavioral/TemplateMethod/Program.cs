namespace DesignPatterns.Behavioral.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Template method defines the program skeleton of an algorithm in an operation, 
            // deferring some steps to subclasses.
            var algorithm = new Algorithm();
            algorithm.TemplateMethod(new ConcreteClassA());
            algorithm.TemplateMethod(new ConcreteClassB());
        }
    }
}
