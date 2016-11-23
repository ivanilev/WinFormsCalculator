using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations
{
    public class Multiply : IOperation
    {
        public double Calculate(double? a, double? b)
        {
            return (a ?? 0) * (b ?? 0);
        }
    }
}
