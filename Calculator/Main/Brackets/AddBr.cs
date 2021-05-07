using System;
using Calculator.Interfaces;
using Calculator.Main.Expressions;

namespace Calculator.Main.Brackets
{
    public class AddBr : IExpressionBracket
    {
        private readonly IExpressionBracket _next;

        public AddBr(IExpressionBracket next)
        {
            _next = next;
        }
        public void Add(ref int priority, string exp, IBuilder builder)
        {
            if (exp.Equals("+", StringComparison.Ordinal))
            {
                priority++;

                var expression = new AddExpression();

                expression.Priority = priority + 3000;

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