using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Equation
    {
        public Equation()
        {

        }

        public string firstNumber { get; set; }
        public string secondNumber { get; set; }
        public string operand { get; set; }
        public double result { get; set; }

        private double firstNum = 0;
        private double secondNum = 0;

        public void AssignNumber(string number)
        {
            if (operand == null)
            {
                firstNumber += number;
            }
            else
            {
                secondNumber += number;
            }
        }

        public double Equals()
        {
            firstNum = Convert.ToDouble(firstNumber);
            secondNum = Convert.ToDouble(secondNumber);
            switch (operand)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
            }
            return result;
        }

        public void Continue()
        {
            firstNumber = Convert.ToString(result);
            secondNumber = null;
        }


    }
}
