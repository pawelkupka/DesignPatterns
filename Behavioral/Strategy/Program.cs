namespace DesignPatterns.Behavioral.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strategy (or policy) enables selecting an algorithm at runtime
            var strategyA = new StrategyA();
            var strategyB = new StrategyB();
            var context = new Context();
            context.Execute(strategyA);
            context.Execute(strategyB);
        }
    }
}
