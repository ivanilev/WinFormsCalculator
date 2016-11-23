using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorOperations
{
    public class CalculatorController
    {

        double? memory = null;
        double? param1;
        double? param2;
        static Stack<Calculator.ResultHistory> operationHistory = new Stack<Calculator.ResultHistory>();
        

        IOperation currentOperation = null;
        IOperation lastOperation = null;

        Factory.OperationFactory oFactory = new Factory.OperationFactory();
        

        public void SaveMemory(string textBox)
        {
            double value;

            if (double.TryParse(textBox,out value))
            {
                memory = value;
            }
            else
            {
                memory = null;
            }
        }
        public double? RecallMemory()
        {
            return memory;
        }
        public void ClearMemory()
        {
            memory = null;
        }

        
      

        public bool Validate(string text)
        {
            Regex regex = new Regex(@"^[1-9][0-9]*[+\-*\/=]$");
            Match match = regex.Match(text);
            return match.Success;
        }

        /// <summary>
        /// Processes an arithmetic equation.
        /// </summary>
        /// <param name="equation">The equation which should to be processed.</param>
        /// <returns>The calculated value.</returns>
        public double OnOperation(string equation)
        {
            //Declare variables for the symbol and the number from the equation 
            double parsedNumber;
            char symbol;

            //Assign the number to the variable
            string number = equation.Substring(0, equation.Length - 1);
            if (!double.TryParse(number, out parsedNumber)) { parsedNumber = 0.00; }
            //Assign the symbol to the variable
            symbol = equation[equation.Length - 1];

            //If it's the first operation save the process in result history and return the value of param1
            if (param1.Equals(null))
            {
                param1 = parsedNumber;
                currentOperation = oFactory.GetOperation(symbol);
                operationHistory.Push(new Calculator.ResultHistory(
                    oFactory.GetOperation(symbol),
                    param1
                    ));
                return param1 ?? 0.00;
            }

            //If not - save the process, save the result in param1 and return the value of param1 (a.k.a. the result)
            param2 = parsedNumber;
            lastOperation = currentOperation;
            currentOperation = oFactory.GetOperation(symbol);


            operationHistory.Push(new Calculator.ResultHistory(
                lastOperation,
                param1,
                param2
                ));

            param1 = lastOperation.Calculate(param1, param2);
            return param1 ?? 0.00;
        }

        /// <summary>
        /// Reverses the last executed command.
        /// </summary>
        public void UndoOperation()
        {
            //Remove the last operation from the stack and pass its parameters' values to the current parameters
            if (operationHistory.Count != 0)
            {
                Calculator.ResultHistory theLastOperation = operationHistory.Pop();
                
                param1 = theLastOperation.param1;
                currentOperation = theLastOperation.operation;
                param2 = null;

                if (operationHistory.Count != 0)
                    lastOperation = operationHistory.Peek().operation;
            }
        }

    }
}
