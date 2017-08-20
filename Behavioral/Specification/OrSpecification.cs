namespace DesignPatterns.Behavioral.Specification
{
    public class OrSpecification : CompositeSpecification
    {
        private readonly ISpecification _leftCondition;
        private readonly ISpecification _rightCondition;

        public OrSpecification(ISpecification leftCondition, ISpecification rightCondition)
        {
            _leftCondition = leftCondition;
            _rightCondition = rightCondition;
        }

        public override bool IsSatisfiedBy(object candidate)
        {
            return _leftCondition.IsSatisfiedBy(candidate) || _rightCondition.IsSatisfiedBy(candidate);
        }
    }
}
