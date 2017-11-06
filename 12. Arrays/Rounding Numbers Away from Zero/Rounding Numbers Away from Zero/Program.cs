using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arry = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i <  arry.Length; i++)

            {
                double roundet = Math.Round(arry[i],0,MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", arry[i], roundet);
            }
        }
        }
    }



