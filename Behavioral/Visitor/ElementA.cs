using System;

namespace DesignPatterns.Behavioral.Visitor
{
    public class ElementA : IElement
    {
        readonly IElement _next;

        public ElementA() { }

        public ElementA(IElement next)
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
            Console.WriteLine("ElementA1");
        }

        public void ShowMessage2()
        {
            Console.WriteLine("ElementA2");
        }
    }
}
