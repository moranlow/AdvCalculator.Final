using System;
using System.Collections.Generic;

namespace Calculator.Interfaces
{
    public interface IValidator
    {
        Tuple<bool, int> IsValid(IEnumerable<string> expressions);
    }
}
