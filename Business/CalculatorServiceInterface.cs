using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanNumeralCalculator.Business
{
    public interface CalculatorServiceInterface
    {
        /**
         * Returns the sum of two ints
         * params: int, int
         * return int
         */
        public int add(int a, int b);

        /**
         * Returns the result of int - int
         * params: int, int
         * return int
         */
        public int subtract(int a, int b);

        /**
         * Returns the product of two ints
         * params: int, int
         * return int
         */
        public int multiply(int a, int b);

        /**
         * Returns the result of int/int
         * params: int, int
         * return int
         */
        public int divide(int a, int b);
    }
}
