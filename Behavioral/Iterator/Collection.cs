using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    public class Collection : IEnumerable
    {
        private readonly ArrayList _elements;

        public Collection()
        {
            _elements = new ArrayList();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var element in _elements)
                yield return element;
        }

        public void Add(string element)
        {
            _elements.Add(element);
        }
    }
}
