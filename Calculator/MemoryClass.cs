using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations
{
    public class MemoryClass
    {
        private double? currentMemory = null;

        public void SaveMemory(double mem)
        {
            currentMemory = mem;
        }

        public double? Recallmemory()
        {
            return currentMemory;
        }

        public void clearMemory()
        {
            currentMemory = null;
        }
    }
}
