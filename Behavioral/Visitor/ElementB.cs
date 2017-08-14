using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class ElementB : IElement
    {
        readonly IElement _next;

        public ElementB() { }

        public ElementB(IElement next)
        {
            _next = next;
        }

        public IElement Next
        {
            get { return _next; }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void ShowMessage1()
        {
            Console.WriteLine("ElementB1");
        }

        public void ShowMessage2()
        {
            Console.WriteLine("ElementB2");
        }
    }
}
