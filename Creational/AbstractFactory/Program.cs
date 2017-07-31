namespace DesignPatterns.Creational.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var productFactory = new ConcreteProductFactory(); // Factory defines an interface for creating an object
            var product1 = productFactory.CreateConcreteProduct1();
            var product2 = productFactory.CreateConcreteProduct2();
        }
    }
}
