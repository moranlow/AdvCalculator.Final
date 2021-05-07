
namespace Calculator.Interfaces
{
    public interface IParser
    {
        IExpression Parse(string expression);
    }
}
