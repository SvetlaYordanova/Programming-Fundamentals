using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            for (int i =1; i <= n-1 ; i++)
            {
                PrintNumber(1, i);
            }
            for (int i =n ; i >=1 ; i--)
            {
                PrintNumber(1,i);
            }

        }

        private static void PrintNumber(int start, int n)
        {
            for (int i =start; i <= n; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    }

    

