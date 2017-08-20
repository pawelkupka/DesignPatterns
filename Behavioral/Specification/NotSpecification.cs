namespace DesignPatterns.Behavioral.Specification
{
    public class NotSpecification : CompositeSpecification
    {
        private readonly ISpecification _condition;

        public NotSpecification(ISpecification condition)
        {
            _condition = condition;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            return !_condition.IsSatisfiedBy(candidate);
        }
    }
}
