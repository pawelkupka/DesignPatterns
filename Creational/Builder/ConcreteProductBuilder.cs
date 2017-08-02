namespace DesignPatterns.Creational.Builder
{
    public class ConcreteProductBuilder : IProductBuilder
    {
        private string _part1 = string.Empty;
        private string _part2 = string.Empty;

        public void BuildPart1(string value)
        {
            _part1 = value;
        }

        public void BuildPart2(string value)
        {
            _part2 = value;
        }

        public Product GetResult()
        {
            return new Product(_part1, _part2);
        }
    }
}
