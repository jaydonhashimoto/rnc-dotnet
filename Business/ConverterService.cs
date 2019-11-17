using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RomanNumeralCalculator.Business
{
    public class ConverterService : ConverterServiceInterface
    {
        /**
         * Returns Roman Numeral given an int
         */
        private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        /**
         * Returns roman numeral given an int
         * params: int
         * returns string
         */
        public string intToRoman(int num)
        {
            //if num >= value, return value and append to final result
            //subtract that value from num
            //exit when num == 0
            if (num < 1) return string.Empty;
            if (num >= 1000) return "M" + intToRoman(num - 1000);
            if (num >= 900) return "CM" + intToRoman(num - 900);
            if (num >= 500) return "D" + intToRoman(num - 500);
            if (num >= 400) return "CD" + intToRoman(num - 400);
            if (num >= 100) return "C" + intToRoman(num - 100);
            if (num >= 90) return "XC" + intToRoman(num - 90);
            if (num >= 50) return "L" + intToRoman(num - 50);
            if (num >= 40) return "XL" + intToRoman(num - 40);
            if (num >= 10) return "X" + intToRoman(num - 10);
            if (num >= 9) return "IX" + intToRoman(num - 9);
            if (num >= 5) return "V" + intToRoman(num - 5);
            if (num >= 4) return "IV" + intToRoman(num - 4);
            if (num >= 1) return "I" + intToRoman(num - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }

        /**
         * Returns an int given roman numeral
         * params: string
         * returns int
         */
        public int romanToInterger(string str)
        {
            int num = 0;
            // look ahead at the next RN string to see 
            // if the RN should be subtracted or added to the total
            for (int i = 0; i < str.Length; i++)
            {
                if (i + 1 < str.Length && RomanMap[str[i]] < RomanMap[str[i + 1]])
                {
                    num -= RomanMap[str[i]];
                }
                else
                {
                    num += RomanMap[str[i]];
                }
            }
            return num;
        }
    }
}
