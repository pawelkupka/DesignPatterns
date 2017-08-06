namespace DesignPatterns.Structural.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // The composite pattern describes a group of objects that is treated the same way 
            // as a single instance of the same type of object
            var component = new Composite("CompositeA+")
                .Add(new Component("- ComponentA1"))
                .Add(new Component("- ComponentA2"))
                .Add(new Composite("- CompositeB+")
                    .Add(new Component("  - ComponentB1"))
                    .Add(new Component("  - ComponentB2")));
            component.Operation();
        }
    }
}
