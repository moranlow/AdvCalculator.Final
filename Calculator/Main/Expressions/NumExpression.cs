using Calculator.Interfaces;

namespace Calculator.Main.Expressions
{
    sealed class NumExpression : IExpression
    {
        private readonly double _variable;
        public NumExpression(double variable)
        {
            _variable = variable;
        }

        public IExpression Left { get; set; }
        public IExpression Right { get; set; }
        public int Priority { get; set; }

        public double Interpret()
        {
            return _variable;
        }
    }
}
