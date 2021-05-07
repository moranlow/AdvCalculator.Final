using System.Globalization;
using System.Text.RegularExpressions;
using Calculator.Interfaces;
using Calculator.Main.Expressions;

namespace Calculator.Main.Brackets
{
    public class NumBr : IExpressionBracket
    {
        private readonly IExpressionBracket _next;

        public NumBr(IExpressionBracket next)
        {
            _next = next;
        }

        public void Add(ref int priority, string exp, IBuilder builder)
        {
            if (Regex.IsMatch(exp, @"^\d+\.?\d*$"))
            {
                priority++;

                var value = double.Parse(exp, CultureInfo.CreateSpecificCulture("en-US"));

                var expression = new NumExpression(value);

                expression.Priority = priority;

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
