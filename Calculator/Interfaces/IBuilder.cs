
namespace Calculator.Interfaces
{
    public interface IBuilder
    {
        void Append(string expression);
        IExpression Build();
        void Append(IExpression expression);
        void Clear();
    }
}
