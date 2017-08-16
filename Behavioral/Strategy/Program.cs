namespace DesignPatterns.Behavioral.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strategy (or policy) enables selecting an algorithm at runtime
            var strategyA = new StrategyA();
            var strategyB = new StrategyB();
            var contextA = new Context(strategyA);
            var contextB = new Context(strategyB);
            contextA.Execute();
            contextB.Execute();
        }
    }
}
