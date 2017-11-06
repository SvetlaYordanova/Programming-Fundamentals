using System;

namespace Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var number = new int [n];

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            var revursNumbers = new int[number.Length];

            for (int i = 0; i < n; i++)
            {
                revursNumbers[i] = number[number.Length - i - 1];

                Console.WriteLine(revursNumbers[i]);
            }

          
        }
    }
}
