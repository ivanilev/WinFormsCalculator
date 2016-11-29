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

            //Parse the number and the symbol from the Equation
            double parsedNumber;
            char symbol;
            string number = equation.Substring(0, equation.Length - 1);
            if (!double.TryParse(number, out parsedNumber)) { parsedNumber = 0.00; }
            symbol = equation[equation.Length - 1];

            //Declare a variable for the result
            double? result;

            //If the first parameter is null assign the current value and operation to the internal properties. Return value is the first parameter.
            if (param1.Equals(null))
            {
                param1 = parsedNumber;
                currentOperation = oFactory.GetOperation(symbol);
                return param1 ?? 0.00;
            }
            else if //if the last two operations are "=" 
                ((oFactory.GetOperation(symbol).GetType() == currentOperation.GetType()) &&
                currentOperation.GetType() == typeof(Equate))                
                {
                    param2 = parsedNumber;
                    result = currentOperation.Calculate(param1, param2); //calculate the result

                    //Save operation
                    operationHistory.Push(new Calculator.ResultHistory(
                            currentOperation,
                            param1,
                            param2));
                    
                    //Nullify all parameters
                    param1 = null;
                    param2 = null;
                    currentOperation = null;

                }
                else //All other cases:
                {

                    //Pass the value to param2
                    param2 = parsedNumber;

                    //Calculate the result
                    result = currentOperation.Calculate(param1, param2);

                    //Save the operation
                    operationHistory.Push(new Calculator.ResultHistory(
                        currentOperation, 
                        param1, 
                        param2
                        ));

                    //Reassign values before ending
                    param1 = result;
                    lastOperation = currentOperation;
                    currentOperation = oFactory.GetOperation(symbol);
                    param2 = null;
                }

            //If it's not null - return result
            //Else return 0.00
            return result ?? 0.00;
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
                else
                    lastOperation = null;
            }
            else
            {
                param1 = null;
                param2 = null;
                lastOperation = null;
            }
        }

    }
}
