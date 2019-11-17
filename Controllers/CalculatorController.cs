using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RomanNumeralCalculator.Models;
using RomanNumeralCalculator.Business;

namespace RomanNumeralCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        // initialize variables
        public CalculatorServiceInterface _calcSI;
        public ConverterServiceInterface _conSI;
        Calculator res = new Calculator();

        /**
         * Dependency Injection via contructor
         */
        public CalculatorController(CalculatorServiceInterface calcSI, ConverterServiceInterface conSI)
        {
            _calcSI = calcSI;
            _conSI = conSI;
        }

        /**
         * Retrieves data from CalculatorAPIController
         */
        public Calculator getData(Calculator calc)
        {
            // set data to local variable
            res = calc;
            return calculate();
        }

        /**
         * Converts variables to and from roman and perform operations
         */
        public Calculator calculate()
        {
            //convert operands to integers
            int op1 = _conSI.romanToInterger(res.operand1);
            int op2 = _conSI.romanToInterger(res.operand2);
            //init solution
            int solution = 0;

            string operation = res.operation;
            //perform operation based on operator
            switch (operation)
            {
                case "+":
                    solution = _calcSI.add(op1, op2);
                    break;
                case "-":
                    solution = _calcSI.subtract(op1, op2);
                    break;
                case "*":
                    solution = _calcSI.multiply(op1, op2);
                    break;
                case "/":
                    solution = _calcSI.divide(op1, op2);
                    break;
            }

            // if solution less than 0, return negative value
            if(solution < 0)
            {
                solution *= -1;
                res.answer = "-"+_conSI.intToRoman(solution);
                return res;
            }
            //convert answer to roman
            res.answer = _conSI.intToRoman(solution);
            return res;
        }
    }
}