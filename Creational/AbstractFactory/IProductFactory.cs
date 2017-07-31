namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IProductFactory
    {
        IProduct CreateConcreteProduct1();
        IProduct CreateConcreteProduct2();
    }
}
