using System;
using Calculator.Interfaces;
using Calculator.Main.Expressions;

namespace Calculator.Main.Brackets
{
    public class DivisionBr : IExpressionBracket
    {
        private readonly IExpressionBracket _next;

        public DivisionBr(IExpressionBracket next)
        {
            _next = next;
        }
        public void Add(ref int priority, string exp, IBuilder builder)
        {
            if (exp.Equals("/", StringComparison.Ordinal))
            {
                priority++;

                var expression = new Division();

                expression.Priority = priority + 2000;

                builder.Append(expression);
            }
            else
            {
                if (_next != null)
                    _next.Add(ref priority, exp, builder);
            }
        }
    }
}
