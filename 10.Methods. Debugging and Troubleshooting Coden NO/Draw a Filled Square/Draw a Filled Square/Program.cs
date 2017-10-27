using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeader( n);
            PrintBoddy(n);
            PrintHeader( n);
            
        }

        private static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }

        static void PrintBoddy(int n)

        {

            for (int i = 1; i <= n-2; i++)
            
        {
            Console.Write("-");
            for (int j = 1; j < n; j++)
            {
                Console.Write ("\\/");
            }

            Console.WriteLine("-");
        }


        }

}
}
