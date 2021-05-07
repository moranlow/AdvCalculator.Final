using System;
using Calculator.Interfaces;
using Calculator.Main;
using Calculator.Main.Brackets;

namespace AdvCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calc = new Calculator.Main.CalculatorApp(new Parser(new Builder(
                          new OpeningBr(
                              new ClosingBr(
                                  new NumBr(
                                      new AddBr(
                                          new SubtractBr(
                                              new MultiplicationBr(
                                                  new DivisionBr(
                                                      null))))))))
                      , new Validator())
                  , new Logger(new Writer()));

            Console.WriteLine("Avaliable operators: -,+,/,*,(, ); example: 2+2*2+(3.4+2.4)");

            while (true)
            {
                string expression = Console.ReadLine();

                try
                {
                    Console.WriteLine("= " + calc.Calculate(expression));
                }
                catch
                {
                    Console.WriteLine("Error! Try again!");
                }
            }
        }
    }
}
