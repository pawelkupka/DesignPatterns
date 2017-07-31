namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteProductFactory : IProductFactory
    {
        public IProduct CreateConcreteProduct1()
        {
            return new ConcreteProduct1();
        }

        public IProduct CreateConcreteProduct2()
        {
            return new ConcreteProduct2();
        }
    }
}
