using System;
using Calculator.Interfaces;

namespace Calculator.Main
{
    public sealed class CalculatorApp : ICalculator
    {
        private readonly IParser _parser;
        private readonly ILogger _logger;

        public CalculatorApp(IParser parser, ILogger logger)
        {
            _parser = parser;
            _logger = logger;
        }

        public double Calculate(string expression)
        {
            try
            {
                var exp = _parser.Parse(expression);

                return exp.Interpret();

            }
            catch (Exception ex)
            {
                _logger.Log("Sorry... Can't calculate it! ", ex);
                throw;
            }
        }
    }
}
