namespace DesignPatterns.Behavioral.Visitor
{
    public class Visitor1 : IVisitor
    {
        public void Visit(ElementA element)
        {
            element.ShowMessage1();
            if (element.Next != null)
                element.Next.Accept(this);
        }

        public void Visit(ElementB element)
        {
            element.ShowMessage1();
            if (element.Next != null)
                element.Next.Accept(this);
        }
    }
}
