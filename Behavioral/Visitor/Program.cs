namespace DesignPatterns.Behavioral.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Visitor allows to add new operations to existent object structures 
            // without modifying the structures
            var visitor1 = new Visitor1();
            var visitor2 = new Visitor2();
            var objectStructure =
                new ElementA(
                    new ElementB(
                        new ElementA()));

            objectStructure.Accept(visitor1);
            objectStructure.Accept(visitor2);
        }
    }
}
