namespace DesignPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(ElementA element);
        void Visit(ElementB element);
    }
}
