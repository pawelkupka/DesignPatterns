namespace DesignPatterns.Creational.FactoryMethod
{
    public class Creator
    {
        public IProduct FactoryMethod(ProductType type)
        {
            if (type == ProductType.Product1)
                return new ConcreteProduct1("Product1");
            else
                return new ConcreteProduct2("Product2");
        }
    }
}
