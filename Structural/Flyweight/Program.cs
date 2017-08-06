namespace DesignPatterns.Structural.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Flyweight is an object that minimizes memory usage by sharing as much data 
            // as possible with other similar objects
            var flyweightFactory = new FlyweightFactory();
            var flyweight1 = flyweightFactory.GetFlyweight("flyweight1");
            var flyweight2 = flyweightFactory.GetFlyweight("flyweight1");
            flyweight1.Operation();
            flyweight2.Operation();
        }
    }
}
