using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations
{
    public class Subract : IOperation
    {
        public double Calculate(double? a, double? b)
        {
            return (a ?? 0) - (b ?? 0);
        }
    }
}
