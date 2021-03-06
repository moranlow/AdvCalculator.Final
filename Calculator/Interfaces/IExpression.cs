
namespace Calculator.Interfaces
{
    public interface IExpression
    {
        double Interpret();
        int Priority { get; set; }
        IExpression Left { get; set; }
        IExpression Right { get; set; }

    }
}
