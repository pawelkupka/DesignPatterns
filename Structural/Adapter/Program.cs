namespace DesignPatterns.Structural.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var adapter = new Adapter(); // This pattern is converting the interface of one class into an interface expected by the client
            adapter.AdaptedMethod("Hello", "World!");
            adapter.AdapteeMethod("Hi");
        }
    }
}
