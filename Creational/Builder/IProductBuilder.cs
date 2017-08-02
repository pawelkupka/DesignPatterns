namespace DesignPatterns.Creational.Builder
{
    public interface IProductBuilder
    {
        void BuildPart1(string value);
        void BuildPart2(string value);
        Product GetResult();
    }
}
