namespace DesignPatterns.Behavioral.Interpreter
{
    public class NonterminalExpression : IExpression
    {
        private readonly IExpression _leftExpression;
        private readonly IExpression _rightExpression;

        public NonterminalExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret(Context context)
        {
            var leftValue = _leftExpression.Interpret(context);
            var rightValue = _rightExpression.Interpret(context);
            return leftValue + rightValue;
        }
    }
}
