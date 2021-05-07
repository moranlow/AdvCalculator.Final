using System;
using Calculator.Interfaces;

namespace Calculator.Main.Expressions
{
    class Division : IExpression
    {
        public IExpression Left { get; set; }
        public IExpression Right { get; set; }
        public int Priority { get; set; }

        public double Interpret()
        {
            var right = Right.Interpret();

            if (Math.Abs(right) <= double.Epsilon)
                throw new DivideByZeroException();

            return Left.Interpret() / right;
        }
    }
}
