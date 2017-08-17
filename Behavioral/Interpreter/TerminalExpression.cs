namespace DesignPatterns.Behavioral.Interpreter
{
    public class TerminalExpression : IExpression
    {
        public int Interpret(Context context)
        {
            return int.Parse(context.Tokens.Pop());
        }
    }
}
