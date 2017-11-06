using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

          BigInteger   factorel = 1;
            for (BigInteger i =2; i <=n; i++)

            {
                factorel *= i;
            }
            Console.WriteLine(factorel);
        }
    }
}
