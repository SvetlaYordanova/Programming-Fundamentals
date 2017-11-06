using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] input = new int[n];

            for (int i = 0; i < n; i++)
            {
                int curentNUmber = int.Parse(Console.ReadLine());
                input[i] = curentNUmber;
            }
            Console.WriteLine("Sum = {0}", input.Sum());
            Console.WriteLine("Min = {0}", input.Min());
            Console.WriteLine("Max = {0}", input.Max());
            Console.WriteLine("Average = {0}", input.Average());
        }
    }
}

