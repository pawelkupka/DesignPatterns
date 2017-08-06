namespace DesignPatterns.Structural.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Facade is an object that provides a simplified interface to a larger body of code, 
            // such as a class library
            var facade = new Facade();
            facade.Operation1();
            facade.Operation2();
        }
    }
}
