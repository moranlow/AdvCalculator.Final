using System;

namespace Calculator.Interfaces
{
    public interface ILogger
    {
        void Log(string message, Exception ex);
    }
}
