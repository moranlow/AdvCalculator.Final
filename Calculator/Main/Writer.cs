using System;
using Calculator.Interfaces;

namespace Calculator.Main
{
    public sealed class Writer : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
