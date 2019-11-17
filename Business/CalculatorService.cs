using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanNumeralCalculator.Business
{
    public class CalculatorService : CalculatorServiceInterface
    {
        /**
         * params: int, int
         * return int
         */
        public int add(int a, int b)
        {
            return a + b;
        }

        /**
         * params: int, int
         * return int
         */
        public int divide(int a, int b)
        {
            // return 0 if a/b == 0
            if(a / b == 0) return 0;
            else return a / b;
        }

        /**
         * params: int, int
         * return int
         */
        public int multiply(int a, int b)
        {
            return a * b;
        }

        /**
         * params: int, int
         * return int
         */
        public int subtract(int a, int b)
        {
            // return 0 if a - b == 0
            if (a - b == 0) return 0;
            else return a - b;
        }
    }
}
