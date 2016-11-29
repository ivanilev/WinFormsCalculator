using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations
{
    class Equate : IOperation
    {
        public double Calculate(double? a, double? b)
        {
            //3 = 12 returns 12; 
            //3 = null returns 3
            //null = null returns 0.00;
            return (b ?? (a ?? 0.00));
        }
    }
}
