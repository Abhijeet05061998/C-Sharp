using System;

namespace CsharpFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstOperand = 15;
            int secondOperand = 3;

            int addResult = firstOperand + secondOperand;
            int subResult = firstOperand - secondOperand;
            int multiplyResult = firstOperand * secondOperand;
            int divisionResult = firstOperand / secondOperand;
            Console.WriteLine("Add:-{0} Substract:-{1} Multiply:-{2}, division:-{3}", addResult, subResult, multiplyResult, divisionResult);
        }
    }
}
