using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations
{
    public class Divide : IOperation
    {
        public double Calculate(double? a, double? b)
        {
            if (b == 0 || b.Equals(null)) { throw new ArgumentException(); }

            return (a ?? 0) / (double)b;
        }
    }
}
