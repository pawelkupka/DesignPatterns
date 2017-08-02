namespace DesignPatterns.Creational.Builder
{
    public class ProductBuildDirector
    {
        public void Construct(IProductBuilder builder)
        {
            builder.BuildPart1("Hello");
            builder.BuildPart2("World!");
        }
    }
}
