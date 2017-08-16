namespace DesignPatterns.Behavioral.State
{
    class Program
    {
        static void Main(string[] args)
        {
            // State pattern is cleaner way for an object to change its behavior at runtime 
            // without resorting to large monolithic conditional statements
            var context = new Context();
            context.Request(); // StateA
            context.Request(); // StateB
            context.Request(); // StateA
        }
    }
}
