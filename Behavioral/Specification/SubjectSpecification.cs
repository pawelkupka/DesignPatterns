using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Specification
{
    public class SubjectSpecification : CompositeSpecification
    {
        private readonly string _subject;

        public SubjectSpecification(string subject)
        {
            _subject = subject;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            var subjects = new List<string>
            {
                "subject1",
                "subject2",
                "subject3"
            };
            return subjects.Contains(_subject);
        }
    }
}
