namespace DesignPatterns.Structural.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // The composite pattern describes a group of objects that is treated the same way 
            // as a single instance of the same type of object
            var componentA = new Composite("CompositeA");
            componentA.Add(new Component("CompositeA.ComponentA1"));
            componentA.Add(new Component("CompositeA.ComponentA2"));

            var componentB = new Composite("componentB");
            componentB.Add(new Component("componentB.ComponentB1"));
            componentB.Add(new Component("componentB.ComponentB2"));
            componentB.Add(componentA);
            componentB.Operation();
        }
    }
}
