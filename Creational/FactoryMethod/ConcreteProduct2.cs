namespace DesignPatterns.Creational.FactoryMethod
{
    public class ConcreteProduct2 : IProduct
    {
        public ConcreteProduct2(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
