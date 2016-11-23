using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations.Factory
{
    interface IOperationFactory
    {
        IOperation GetOperation(char c);
    }
}
