using Calculator.Interfaces;

namespace Calculator.Main.Expressions
{
    class Subtract : IExpression
    {
        public IExpression Left { get; set; }
        public IExpression Right { get; set; }
        public int Priority { get; set; }

        public double Interpret()
        {
            return Left.Interpret() - Right.Interpret();
        }
    }
}
