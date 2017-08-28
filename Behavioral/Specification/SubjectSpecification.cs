namespace DesignPatterns.Behavioral.Specification
{
    public class SubjectSpecification : CompositeSpecification
    {
        public SubjectSpecification(string subject)
        {
            Subject = subject;
        }

        public string Subject { get; }

        public override bool IsSatisfiedBy(object candidate)
        {
            var subjectSpecification = candidate as SubjectSpecification;
            if (subjectSpecification == null) return false;
            return subjectSpecification.Subject == Subject;
        }
    }
}
