using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        public string NumberToRoman(int number)
        {
            if (number < 0 || number > 3999)
            {
                throw new ArgumentException("The number you register has to be bigger than 0 and smaller than 3999");
            }

            if (number == 0)
            {
                return "N";
            }

            int[] numbers = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romans = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 13; i++)
            {
                while (number >= numbers[i])
                {
                    number -= numbers[i];
                    result.Append(romans[i]);
                }
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            Program conv = new Program();
            for (int i = 1; i < 100; i++)
            {
                conv.NumberToRoman(i);
            }
            Console.ReadKey();
        }
    }
}
