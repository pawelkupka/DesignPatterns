namespace DesignPatterns.Structural.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decorator pattern allows behavior to be added to an individual object, 
            // without affecting the behavior of other objects from the same class.
            var component = new Component();
            var decoratedComponent = new Decorator(component);
            decoratedComponent.Operation();
        }
    }
}
