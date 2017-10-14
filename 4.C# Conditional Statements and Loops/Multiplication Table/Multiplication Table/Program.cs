using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int multiplaer = 1;

            while (multiplaer <= 10)
            {
                int product = n * multiplaer;

                Console.WriteLine(n + " X " + multiplaer +  " = " + product);
                multiplaer++;
            }
        }
    }
}
