namespace DesignPatterns.Creational.FactoryMethod
{
    public class ConcreteProduct1 : IProduct
    {
        public ConcreteProduct1(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
