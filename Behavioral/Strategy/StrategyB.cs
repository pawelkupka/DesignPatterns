using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class StrategyB : IStrategy
    {
        public void Algorithm(Context context)
        {
            Console.WriteLine("StrategyB");
        }
    }
}
