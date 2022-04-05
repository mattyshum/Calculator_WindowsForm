using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Equation
    {

        public string number { get; set; }

        public double numberNum;
        public string total { get; set; }

        public double totalNum;
        public string operand { get; set; }
  
        public void buildNumber(string digit)
        {
            number += digit;
        }

        public void Operand(string operand)
        {
            this.operand = operand;

            if (total == null)
            {
                total = number;
                number = null;
            }
            else if (number != null)
            {
                Equals();
            }
        }
        public void Equals()
        {
            numberNum = Convert.ToDouble(number);
            totalNum = Convert.ToDouble(total);
            switch (operand)
            {
                case "+":
                    totalNum += numberNum;
                    break;
                case "-":
                    totalNum -= numberNum;
                    break;
                case "*":
                    totalNum *= numberNum;
                    break;
                case "/":
                    totalNum /= numberNum;
                    break;
            }

            number = null;
            total = Convert.ToString(totalNum);
        }

        public void Clear()
        {
            number = null;
            total = null;
            operand = null;
            numberNum = 0;
            totalNum = 0;
        }
        
    }
}
