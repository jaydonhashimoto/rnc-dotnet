using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanNumeralCalculator.Business
{
    public interface ConverterServiceInterface
    {
        /**
         * Returns an int given roman
         * params: string
         * returns int
         */
        public int romanToInterger(string str);

        /**
         * Returns roman given an int
         * params: int
         * returns string
         */
        public string intToRoman(int num);
    }
}
