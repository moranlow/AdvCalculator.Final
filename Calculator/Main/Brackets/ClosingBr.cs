using System;
using Calculator.Interfaces;

namespace Calculator.Main.Brackets
{
    public class ClosingBr : IExpressionBracket
    {
        IExpressionBracket _next;
        public ClosingBr(IExpressionBracket next)
        {
            _next = next;
        }
        public void Add(ref int priority, string exp, IBuilder builder)
        {
            if (exp.Equals(")", StringComparison.Ordinal))
            {
                priority += 10000;
            }
            else
            {
                if (_next != null)
                    _next.Add(ref priority, exp, builder);
            }
        }
    }
}
