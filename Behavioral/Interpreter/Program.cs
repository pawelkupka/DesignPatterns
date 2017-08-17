using System;

namespace DesignPatterns.Behavioral.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interpreter pattern specifies how to evaluate sentences in a language
            var context = new Context("3 4 2");
            var syntaxTree = new NonterminalExpression(
                new NonterminalExpression(
                    new TerminalExpression(), new TerminalExpression()), 
                new TerminalExpression());

            Console.WriteLine(syntaxTree.Interpret(context)); // 9
        }
    }
}
