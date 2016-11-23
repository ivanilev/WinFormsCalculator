using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperations.Factory
{
    public class OperationFactory : IOperationFactory
    {
        //a dictionary to hold all operations
        private Dictionary<char, IOperation> _operations;

        /// <summary>
        /// Factory
        /// </summary>
        public OperationFactory()
        {
            InitOperations();
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitOperations()
        {
            _operations = new Dictionary<char, IOperation>();

            _operations.Add('+', new Add());
            _operations.Add('-', new Subract());
            _operations.Add('*', new Multiply());
            _operations.Add('/', new Divide());
            _operations.Add('=', new Equate());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public IOperation GetOperation(char c)
        {
            try
            {
                return _operations[c];
            }
            catch
            {
                throw new NullReferenceException("operation not found");
            }
        }
        public char[] GetAllOperationSymbols()
        {
            return _operations.Select(x => x.Key).ToArray();
        }
    }
}
