using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberr = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(numberr));
        }

        public static int GetMultipleOfEvensAndOdds(int number)
        {
            return Math.Abs(GetSumOfEvenDigits(number) *GetSumOfOddDigits(number));

        }

        public static int GetSumOfOddDigits(int number)
        {

            return GetSumOfDigis(number, 1);

        }

        public static int GetSumOfEvenDigits(int number)

        {
            return GetSumOfDigis(number, 0);

        }

        public static int GetSumOfDigis(int number, int remeinder)
        {
            var result = 0;
            foreach (var symvol in number.ToString())
            {
                var digit = symvol - '0';
                if (digit % 2 == remeinder)
                {
                    result += digit;
                }
            }
            return result;
        }
    }
}
