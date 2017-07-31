namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var prototype1 = new ConcretePrototype1();
            var prototype2 = new ConcretePrototype2();

            var prototype = prototype1.Clone();
            prototype.DisplayState();

            prototype = prototype2.Clone();
            prototype.DisplayState();
        }
    }
}
