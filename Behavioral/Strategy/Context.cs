namespace DesignPatterns.Behavioral.Strategy
{
    public class Context
    {
        public void Execute(IStrategy strategy)
        {
            strategy.Algorithm(this);
        }
    }
}
