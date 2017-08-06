namespace DesignPatterns.Structural.Twin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Twin pattern allows to model multiple inheritance
            var child1 = new Child1();
            child1.OperationFromParent1();
            child1.OperationFromParent2();
        }
    }
}
