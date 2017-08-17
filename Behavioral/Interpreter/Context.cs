using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Interpreter
{
    public class Context
    {
        private readonly Stack<string> _tokens;

        public Context(string expression)
        {
            var tokens = expression.Split(' ');
            Array.Reverse(tokens);
            _tokens = new Stack<string>(tokens);
        }
        public Stack<string> Tokens
        {
            get { return _tokens; }
        }

        public int Output { get; set; }
    }
}
