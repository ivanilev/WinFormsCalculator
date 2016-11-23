using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ResultHistory
    {
        public double? param1;
        public double? param2;
        public CalculatorOperations.IOperation operation;

        public ResultHistory(CalculatorOperations.IOperation Operation, double? P1 = 0.00, double? P2 = 0.00)
        {
            operation = Operation;
            param1 = P1;
            param2 = P2;
        }
        public double GetCurrentOperationResult()
        {
            return operation.Calculate(param1, param2);
        }
    }
}
