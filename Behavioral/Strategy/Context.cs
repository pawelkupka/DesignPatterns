namespace DesignPatterns.Behavioral.Strategy
{
    public class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Execute()
        {
            _strategy.Algorithm(this);
        }
    }
}
