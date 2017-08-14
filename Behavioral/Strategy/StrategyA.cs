using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class StrategyA : IStrategy
    {
        public void Algorithm(Context context)
        {
            Console.WriteLine("StrategyA");
        }
    }
}
