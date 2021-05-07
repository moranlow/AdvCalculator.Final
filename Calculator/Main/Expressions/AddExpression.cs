using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Interfaces;

namespace Calculator.Main.Expressions
{
    class AddExpression : IExpression
    {
        public IExpression Left { get; set; }
        public IExpression Right { get; set; }
        public int Priority { get; set; }

        public double Interpret()
        {
            return Left.Interpret() + Right.Interpret();
        }
    }
}
