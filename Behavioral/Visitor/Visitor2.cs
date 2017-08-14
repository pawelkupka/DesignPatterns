namespace DesignPatterns.Behavioral.Visitor
{
    public class Visitor2 : IVisitor
    {
        public void Visit(ElementA element)
        {
            element.ShowMessage2();
            if (element.Next != null)
                element.Next.Accept(this);
        }

        public void Visit(ElementB element)
        {
            element.ShowMessage2();
            if (element.Next != null)
                element.Next.Accept(this);
        }
    }
}
