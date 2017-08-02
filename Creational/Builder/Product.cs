namespace DesignPatterns.Creational.Builder
{
    public class Product
    {
        public Product(string part1, string part2)
        {
            Part1 = part1;
            Part2 = part2;
        }

        public string Part1 { get; }
        public string Part2 { get; }

        public override string ToString()
        {
            return $"{Part1} {Part2}";
        }
    }
}
