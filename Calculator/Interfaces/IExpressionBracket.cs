
namespace Calculator.Interfaces
{
    public interface IExpressionBracket
    {
        void Add(ref int priority, string exp, IBuilder builder);
    }
}
