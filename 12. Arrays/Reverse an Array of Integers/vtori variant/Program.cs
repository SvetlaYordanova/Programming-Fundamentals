using System;

namespace vtori_variant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var number = new int[n];

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            

            for (int i =number.Length-1; i >=0; i--)
            {
                Console.WriteLine(number[i]);
            }
            }
        }
    }

